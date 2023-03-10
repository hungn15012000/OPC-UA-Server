/* ========================================================================
 * Copyright (c) 2005-2020 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;
using Opc.Ua;
using Opc.Ua.Configuration;
using System.IO;
using System.Linq;

namespace Opc.Ua.Server.Controls
{
    /// <summary>
    /// The primary form displayed by the application.
    /// </summary>
    public partial class ServerForm : Form
    {
        #region Constructors
        /// <summary>
        /// Creates an empty form.
        /// </summary>
        public ServerForm()
        {
            InitializeComponent();  
        }
        
        /// <summary>
        /// Creates a form which displays the status for a UA server.
        /// </summary>
        public ServerForm(StandardServer server, ApplicationConfiguration configuration)
        {
            InitializeComponent();

            m_server = server;
            m_configuration = configuration;


            this.home1.Initialize(m_server, m_configuration);
            this.serverDiagnosticsCtrl1.Initialize(m_server, m_configuration);
            this.endpoint1.Initialize(m_server, m_configuration);


        }


        /// <summary>
        /// Creates a form which displays the status for a UA server.
        /// </summary>
        public ServerForm(ApplicationInstance application, bool showCertificateValidationDialog = false)
        {
            InitializeComponent();

            m_application = application;
            m_server = application.Server as StandardServer;
            m_configuration = application.ApplicationConfiguration;

            if (showCertificateValidationDialog &&
                !application.ApplicationConfiguration.SecurityConfiguration.AutoAcceptUntrustedCertificates)
            {
                application.ApplicationConfiguration.CertificateValidator.CertificateValidation += new CertificateValidationEventHandler(CertificateValidator_CertificateValidation);
            }

            //Enable Timer for update server information
            timer.Enabled = true;
            timer.Interval = 1000;

            //Set up for home tab
            this.home1.Initialize(m_server, m_configuration);
            this.serverDiagnosticsCtrl1.Initialize(m_server, m_configuration);
            this.endpoint1.Initialize(m_server, m_configuration);
            this.certification1.Initialize(m_server, m_configuration);
        }

        #endregion

        #region Private Fields
        private ApplicationInstance m_application;
        private StandardServer m_server;
        private ApplicationConfiguration m_configuration;
        #endregion

        #region Event Handlers
        /// <summary>
        /// Handles a certificate validation error.
        /// </summary>
        void CertificateValidator_CertificateValidation(CertificateValidator validator, CertificateValidationEventArgs e)
        {
            try
            {
                HandleCertificateValidationError(this, validator, e);
            }
            catch (Exception exception)
            {
                HandleException(this.Text, MethodBase.GetCurrentMethod(), exception);
            }
        }

        private void ServerForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                //Hide();
            }
        }

        private void TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Server_ExitMI_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ServerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                m_server.Stop();
            }
            catch (Exception exception)
            {
                Utils.Trace(exception, "Error stopping server.");
            }
        }

        private void TrayIcon_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
        #endregion

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quit the application", "OPC UA", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start( Path.GetDirectoryName(Application.ExecutablePath) + Path.DirectorySeparatorChar + "WebHelp" + Path.DirectorySeparatorChar + "index.htm");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to launch help documentation. Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Displays the details of an exception.
        /// </summary>
        public static void HandleException(string caption, MethodBase method, Exception e)
        {
            if (String.IsNullOrEmpty(caption))
            {
                caption = method.Name;
            }
            ExceptionDlg.Show(caption, e);
        }

        /// <summary>
        /// Handles a certificate validation error.
        /// </summary>
        /// <param name="caller">The caller's text is used as the caption of the <see cref="MessageBox"/> shown to provide details about the error.</param>
        /// <param name="validator">The validator (not used).</param>
        /// <param name="e">The <see cref="Opc.Ua.CertificateValidationEventArgs"/> instance event arguments provided when a certificate validation error occurs.</param>
        public static void HandleCertificateValidationError(Form caller, CertificateValidator validator, CertificateValidationEventArgs e)
        {
            StringBuilder buffer = new StringBuilder();
            buffer.AppendLine("Certificate could not be validated!");
            buffer.AppendLine("Validation error(s):");
            ServiceResult error = e.Error;
            while (error != null)
            {
                buffer.AppendFormat("- {0}\r\n", error.ToString().Split('\r','\n').FirstOrDefault());
                error = error.InnerResult;
            }
            buffer.AppendFormat("\r\nSubject: {0}\r\n", e.Certificate.Subject);
            buffer.AppendFormat("Issuer: {0}\r\n", X509Utils.CompareDistinguishedName(e.Certificate.Subject, e.Certificate.Issuer)
                ? "Self-signed" : e.Certificate.Issuer);
            buffer.AppendFormat("Valid From: {0}\r\n", e.Certificate.NotBefore);
            buffer.AppendFormat("Valid To: {0}\r\n", e.Certificate.NotAfter);
            buffer.AppendFormat("Thumbprint: {0}\r\n\r\n", e.Certificate.Thumbprint);
            buffer.Append("Security certificate problems may indicate an attempt to intercept any data you send ");
            buffer.Append("to a server or to allow an untrusted client to connect to your server.");
            buffer.Append("\r\n\r\nAccept anyway?");

            if (MessageBox.Show(buffer.ToString(), caller.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.AcceptAll = true;
            }
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                runningLabel.Text = m_server.CurrentInstance.CurrentState.ToString();
                serverCurrentTimeValue.Text = String.Format("{0:HH:mm:ss}", DateTime.Now);
                sessionValue.Text = Convert.ToString(this.serverDiagnosticsCtrl1.NumberofSeesion());
                subscriptionsValue.Text = Convert.ToString(this.serverDiagnosticsCtrl1.NumberofSubcriptions());
                itemsValue.Text = Convert.ToString(this.serverDiagnosticsCtrl1.NumberofItems());

                this.home1.UpdateServer();
                this.endpoint1.Update();
                this.serverDiagnosticsCtrl1.UpdateServer();
                this.certification1.UpdateCertification();

            }
            catch (Exception exception)
            {
                ServerUtils.HandleException(this.Text, exception);
            }
        }

        private void home1_Load(object sender, EventArgs e)
        {

        }
    }
}
