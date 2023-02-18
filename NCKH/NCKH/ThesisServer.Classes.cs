/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
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
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace ThesisServer
{
    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the PLC1214DCDCDC Object.
        /// </summary>
        public const uint PLC1214DCDCDC = 15077;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton Object.
        /// </summary>
        public const uint PLC1214DCDCDC_OperationButton = 15078;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton_StartButton Object.
        /// </summary>
        public const uint PLC1214DCDCDC_OperationButton_StartButton = 15079;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton_StopButton Object.
        /// </summary>
        public const uint PLC1214DCDCDC_OperationButton_StopButton = 15081;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton_ResetButton Object.
        /// </summary>
        public const uint PLC1214DCDCDC_OperationButton_ResetButton = 15083;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton_AutoButton Object.
        /// </summary>
        public const uint PLC1214DCDCDC_OperationButton_AutoButton = 15085;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton_ManualButton Object.
        /// </summary>
        public const uint PLC1214DCDCDC_OperationButton_ManualButton = 15087;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor Object.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor = 15089;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM Object.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM = 15090;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PusherParameters Object.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM_PusherParameters = 15091;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_BeltParameters Object.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM_BeltParameters = 15094;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters Object.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters = 15096;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorParameters Object.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_SensorParameters = 15103;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters Object.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_AutoStateParameters = 15114;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_CameraParameters Object.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_CameraParameters = 15129;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the GenericControllerType ObjectType.
        /// </summary>
        public const uint GenericControllerType = 15001;

        /// <summary>
        /// The identifier for the AnalogInputType ObjectType.
        /// </summary>
        public const uint AnalogInputType = 15006;

        /// <summary>
        /// The identifier for the AnalogOutputType ObjectType.
        /// </summary>
        public const uint AnalogOutputType = 15017;

        /// <summary>
        /// The identifier for the DigitalType ObjectType.
        /// </summary>
        public const uint DigitalType = 15019;

        /// <summary>
        /// The identifier for the Pusher ObjectType.
        /// </summary>
        public const uint Pusher = 15021;

        /// <summary>
        /// The identifier for the Conveyor ObjectType.
        /// </summary>
        public const uint Conveyor = 15024;

        /// <summary>
        /// The identifier for the PickAndPlace ObjectType.
        /// </summary>
        public const uint PickAndPlace = 15026;

        /// <summary>
        /// The identifier for the Sensor ObjectType.
        /// </summary>
        public const uint Sensor = 15033;

        /// <summary>
        /// The identifier for the AutoStateType ObjectType.
        /// </summary>
        public const uint AutoStateType = 15044;

        /// <summary>
        /// The identifier for the Camera ObjectType.
        /// </summary>
        public const uint Camera = 15059;

        /// <summary>
        /// The identifier for the ValveType ObjectType.
        /// </summary>
        public const uint ValveType = 15062;

        /// <summary>
        /// The identifier for the AnalogSensorType ObjectType.
        /// </summary>
        public const uint AnalogSensorType = 15064;

        /// <summary>
        /// The identifier for the ButtonType ObjectType.
        /// </summary>
        public const uint ButtonType = 15075;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the GenericControllerType_SetPoint Variable.
        /// </summary>
        public const uint GenericControllerType_SetPoint = 15002;

        /// <summary>
        /// The identifier for the GenericControllerType_Kp Variable.
        /// </summary>
        public const uint GenericControllerType_Kp = 15003;

        /// <summary>
        /// The identifier for the GenericControllerType_Ki Variable.
        /// </summary>
        public const uint GenericControllerType_Ki = 15004;

        /// <summary>
        /// The identifier for the GenericControllerType_Kd Variable.
        /// </summary>
        public const uint GenericControllerType_Kd = 15005;

        /// <summary>
        /// The identifier for the AnalogInputType_Output Variable.
        /// </summary>
        public const uint AnalogInputType_Output = 15007;

        /// <summary>
        /// The identifier for the AnalogInputType_Ampere Variable.
        /// </summary>
        public const uint AnalogInputType_Ampere = 15008;

        /// <summary>
        /// The identifier for the AnalogInputType_AmpereStatus Variable.
        /// </summary>
        public const uint AnalogInputType_AmpereStatus = 15009;

        /// <summary>
        /// The identifier for the AnalogInputType_Volt Variable.
        /// </summary>
        public const uint AnalogInputType_Volt = 15010;

        /// <summary>
        /// The identifier for the AnalogInputType_VoltStatus Variable.
        /// </summary>
        public const uint AnalogInputType_VoltStatus = 15011;

        /// <summary>
        /// The identifier for the AnalogInputType_Frequency Variable.
        /// </summary>
        public const uint AnalogInputType_Frequency = 15012;

        /// <summary>
        /// The identifier for the AnalogInputType_Power Variable.
        /// </summary>
        public const uint AnalogInputType_Power = 15013;

        /// <summary>
        /// The identifier for the AnalogInputType_PowerStatus Variable.
        /// </summary>
        public const uint AnalogInputType_PowerStatus = 15014;

        /// <summary>
        /// The identifier for the AnalogInputType_PowerFactor Variable.
        /// </summary>
        public const uint AnalogInputType_PowerFactor = 15015;

        /// <summary>
        /// The identifier for the AnalogInputType_Status Variable.
        /// </summary>
        public const uint AnalogInputType_Status = 15016;

        /// <summary>
        /// The identifier for the AnalogOutputType_Input Variable.
        /// </summary>
        public const uint AnalogOutputType_Input = 15018;

        /// <summary>
        /// The identifier for the DigitalType_Value Variable.
        /// </summary>
        public const uint DigitalType_Value = 15020;

        /// <summary>
        /// The identifier for the Pusher_PushFront Variable.
        /// </summary>
        public const uint Pusher_PushFront = 15022;

        /// <summary>
        /// The identifier for the Pusher_PushBack Variable.
        /// </summary>
        public const uint Pusher_PushBack = 15023;

        /// <summary>
        /// The identifier for the Conveyor_Belt Variable.
        /// </summary>
        public const uint Conveyor_Belt = 15025;

        /// <summary>
        /// The identifier for the PickAndPlace_ZDown Variable.
        /// </summary>
        public const uint PickAndPlace_ZDown = 15027;

        /// <summary>
        /// The identifier for the PickAndPlace_ZUp Variable.
        /// </summary>
        public const uint PickAndPlace_ZUp = 15028;

        /// <summary>
        /// The identifier for the PickAndPlace_XRight Variable.
        /// </summary>
        public const uint PickAndPlace_XRight = 15029;

        /// <summary>
        /// The identifier for the PickAndPlace_XLeft Variable.
        /// </summary>
        public const uint PickAndPlace_XLeft = 15030;

        /// <summary>
        /// The identifier for the PickAndPlace_Pick Variable.
        /// </summary>
        public const uint PickAndPlace_Pick = 15031;

        /// <summary>
        /// The identifier for the PickAndPlace_Release Variable.
        /// </summary>
        public const uint PickAndPlace_Release = 15032;

        /// <summary>
        /// The identifier for the Sensor_SSBeltBegin Variable.
        /// </summary>
        public const uint Sensor_SSBeltBegin = 15034;

        /// <summary>
        /// The identifier for the Sensor_SSBeltEnd Variable.
        /// </summary>
        public const uint Sensor_SSBeltEnd = 15035;

        /// <summary>
        /// The identifier for the Sensor_SSZUp Variable.
        /// </summary>
        public const uint Sensor_SSZUp = 15036;

        /// <summary>
        /// The identifier for the Sensor_SSZDown Variable.
        /// </summary>
        public const uint Sensor_SSZDown = 15037;

        /// <summary>
        /// The identifier for the Sensor_SSX0 Variable.
        /// </summary>
        public const uint Sensor_SSX0 = 15038;

        /// <summary>
        /// The identifier for the Sensor_SSX1 Variable.
        /// </summary>
        public const uint Sensor_SSX1 = 15039;

        /// <summary>
        /// The identifier for the Sensor_SSX2 Variable.
        /// </summary>
        public const uint Sensor_SSX2 = 15040;

        /// <summary>
        /// The identifier for the Sensor_SSX3 Variable.
        /// </summary>
        public const uint Sensor_SSX3 = 15041;

        /// <summary>
        /// The identifier for the Sensor_SSPusherFront Variable.
        /// </summary>
        public const uint Sensor_SSPusherFront = 15042;

        /// <summary>
        /// The identifier for the Sensor_SSPusherBack Variable.
        /// </summary>
        public const uint Sensor_SSPusherBack = 15043;

        /// <summary>
        /// The identifier for the AutoStateType_S0 Variable.
        /// </summary>
        public const uint AutoStateType_S0 = 15045;

        /// <summary>
        /// The identifier for the AutoStateType_S1 Variable.
        /// </summary>
        public const uint AutoStateType_S1 = 15046;

        /// <summary>
        /// The identifier for the AutoStateType_S2 Variable.
        /// </summary>
        public const uint AutoStateType_S2 = 15047;

        /// <summary>
        /// The identifier for the AutoStateType_S3 Variable.
        /// </summary>
        public const uint AutoStateType_S3 = 15048;

        /// <summary>
        /// The identifier for the AutoStateType_S4 Variable.
        /// </summary>
        public const uint AutoStateType_S4 = 15049;

        /// <summary>
        /// The identifier for the AutoStateType_S5 Variable.
        /// </summary>
        public const uint AutoStateType_S5 = 15050;

        /// <summary>
        /// The identifier for the AutoStateType_S6 Variable.
        /// </summary>
        public const uint AutoStateType_S6 = 15051;

        /// <summary>
        /// The identifier for the AutoStateType_S7 Variable.
        /// </summary>
        public const uint AutoStateType_S7 = 15052;

        /// <summary>
        /// The identifier for the AutoStateType_S8 Variable.
        /// </summary>
        public const uint AutoStateType_S8 = 15053;

        /// <summary>
        /// The identifier for the AutoStateType_S9 Variable.
        /// </summary>
        public const uint AutoStateType_S9 = 15054;

        /// <summary>
        /// The identifier for the AutoStateType_S10 Variable.
        /// </summary>
        public const uint AutoStateType_S10 = 15055;

        /// <summary>
        /// The identifier for the AutoStateType_S11 Variable.
        /// </summary>
        public const uint AutoStateType_S11 = 15056;

        /// <summary>
        /// The identifier for the AutoStateType_S12 Variable.
        /// </summary>
        public const uint AutoStateType_S12 = 15057;

        /// <summary>
        /// The identifier for the AutoStateType_S13 Variable.
        /// </summary>
        public const uint AutoStateType_S13 = 15058;

        /// <summary>
        /// The identifier for the Camera_CameraStatus Variable.
        /// </summary>
        public const uint Camera_CameraStatus = 15060;

        /// <summary>
        /// The identifier for the Camera_CameraData Variable.
        /// </summary>
        public const uint Camera_CameraData = 15061;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton_StartButton_Value Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_OperationButton_StartButton_Value = 15080;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton_StopButton_Value Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_OperationButton_StopButton_Value = 15082;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton_ResetButton_Value Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_OperationButton_ResetButton_Value = 15084;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton_AutoButton_Value Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_OperationButton_AutoButton_Value = 15086;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton_ManualButton_Value Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_OperationButton_ManualButton_Value = 15088;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PusherParameters_PushFront Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM_PusherParameters_PushFront = 15092;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PusherParameters_PushBack Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM_PusherParameters_PushBack = 15093;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_BeltParameters_Belt Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM_BeltParameters_Belt = 15095;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_ZDown Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_ZDown = 15097;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_ZUp Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_ZUp = 15098;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_XRight Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_XRight = 15099;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_XLeft Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_XLeft = 15100;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_Pick Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_Pick = 15101;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_Release Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_Release = 15102;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorParameters_SSBeltBegin Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_SensorParameters_SSBeltBegin = 15104;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorParameters_SSBeltEnd Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_SensorParameters_SSBeltEnd = 15105;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorParameters_SSZUp Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_SensorParameters_SSZUp = 15106;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorParameters_SSZDown Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_SensorParameters_SSZDown = 15107;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorParameters_SSX0 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_SensorParameters_SSX0 = 15108;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorParameters_SSX1 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_SensorParameters_SSX1 = 15109;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorParameters_SSX2 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_SensorParameters_SSX2 = 15110;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorParameters_SSX3 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_SensorParameters_SSX3 = 15111;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorParameters_SSPusherFront Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_SensorParameters_SSPusherFront = 15112;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorParameters_SSPusherBack Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_SensorParameters_SSPusherBack = 15113;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S0 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_AutoStateParameters_S0 = 15115;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S1 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_AutoStateParameters_S1 = 15116;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S2 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_AutoStateParameters_S2 = 15117;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S3 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_AutoStateParameters_S3 = 15118;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S4 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_AutoStateParameters_S4 = 15119;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S5 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_AutoStateParameters_S5 = 15120;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S6 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_AutoStateParameters_S6 = 15121;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S7 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_AutoStateParameters_S7 = 15122;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S8 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_AutoStateParameters_S8 = 15123;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S9 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_AutoStateParameters_S9 = 15124;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S10 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_AutoStateParameters_S10 = 15125;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S11 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_AutoStateParameters_S11 = 15126;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S12 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_AutoStateParameters_S12 = 15127;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S13 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_AutoStateParameters_S13 = 15128;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_CameraParameters_CameraStatus Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_CameraParameters_CameraStatus = 15130;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_CameraParameters_CameraData Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_CameraParameters_CameraData = 15131;
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the PLC1214DCDCDC Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_OperationButton = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_OperationButton, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton_StartButton Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_OperationButton_StartButton = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_OperationButton_StartButton, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton_StopButton Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_OperationButton_StopButton = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_OperationButton_StopButton, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton_ResetButton Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_OperationButton_ResetButton = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_OperationButton_ResetButton, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton_AutoButton Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_OperationButton_AutoButton = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_OperationButton_AutoButton, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton_ManualButton Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_OperationButton_ManualButton = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_OperationButton_ManualButton, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_Monitor, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_Monitor_ActuatorM, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PusherParameters Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM_PusherParameters = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_Monitor_ActuatorM_PusherParameters, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_BeltParameters Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM_BeltParameters = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_Monitor_ActuatorM_BeltParameters, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorParameters Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_SensorParameters = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_Monitor_SensorParameters, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_AutoStateParameters = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_Monitor_AutoStateParameters, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_CameraParameters Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_CameraParameters = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_Monitor_CameraParameters, ThesisServer.Namespaces.ThesisServer);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the GenericControllerType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType = new ExpandedNodeId(ThesisServer.ObjectTypes.GenericControllerType, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType = new ExpandedNodeId(ThesisServer.ObjectTypes.AnalogInputType, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogOutputType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogOutputType = new ExpandedNodeId(ThesisServer.ObjectTypes.AnalogOutputType, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the DigitalType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId DigitalType = new ExpandedNodeId(ThesisServer.ObjectTypes.DigitalType, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Pusher ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Pusher = new ExpandedNodeId(ThesisServer.ObjectTypes.Pusher, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Conveyor ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Conveyor = new ExpandedNodeId(ThesisServer.ObjectTypes.Conveyor, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PickAndPlace ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlace = new ExpandedNodeId(ThesisServer.ObjectTypes.PickAndPlace, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Sensor ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Sensor = new ExpandedNodeId(ThesisServer.ObjectTypes.Sensor, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateType = new ExpandedNodeId(ThesisServer.ObjectTypes.AutoStateType, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Camera ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Camera = new ExpandedNodeId(ThesisServer.ObjectTypes.Camera, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the ValveType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ValveType = new ExpandedNodeId(ThesisServer.ObjectTypes.ValveType, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogSensorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorType = new ExpandedNodeId(ThesisServer.ObjectTypes.AnalogSensorType, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the ButtonType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ButtonType = new ExpandedNodeId(ThesisServer.ObjectTypes.ButtonType, ThesisServer.Namespaces.ThesisServer);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the GenericControllerType_SetPoint Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType_SetPoint = new ExpandedNodeId(ThesisServer.Variables.GenericControllerType_SetPoint, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the GenericControllerType_Kp Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType_Kp = new ExpandedNodeId(ThesisServer.Variables.GenericControllerType_Kp, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the GenericControllerType_Ki Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType_Ki = new ExpandedNodeId(ThesisServer.Variables.GenericControllerType_Ki, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the GenericControllerType_Kd Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType_Kd = new ExpandedNodeId(ThesisServer.Variables.GenericControllerType_Kd, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_Output = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_Output, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_Ampere Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_Ampere = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_Ampere, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_AmpereStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_AmpereStatus = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_AmpereStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_Volt Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_Volt = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_Volt, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_VoltStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_VoltStatus = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_VoltStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_Frequency Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_Frequency = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_Frequency, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_Power Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_Power = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_Power, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_PowerStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_PowerStatus = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_PowerStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_PowerFactor Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_PowerFactor = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_PowerFactor, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_Status = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_Status, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogOutputType_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogOutputType_Input = new ExpandedNodeId(ThesisServer.Variables.AnalogOutputType_Input, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the DigitalType_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId DigitalType_Value = new ExpandedNodeId(ThesisServer.Variables.DigitalType_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Pusher_PushFront Variable.
        /// </summary>
        public static readonly ExpandedNodeId Pusher_PushFront = new ExpandedNodeId(ThesisServer.Variables.Pusher_PushFront, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Pusher_PushBack Variable.
        /// </summary>
        public static readonly ExpandedNodeId Pusher_PushBack = new ExpandedNodeId(ThesisServer.Variables.Pusher_PushBack, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Conveyor_Belt Variable.
        /// </summary>
        public static readonly ExpandedNodeId Conveyor_Belt = new ExpandedNodeId(ThesisServer.Variables.Conveyor_Belt, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PickAndPlace_ZDown Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlace_ZDown = new ExpandedNodeId(ThesisServer.Variables.PickAndPlace_ZDown, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PickAndPlace_ZUp Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlace_ZUp = new ExpandedNodeId(ThesisServer.Variables.PickAndPlace_ZUp, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PickAndPlace_XRight Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlace_XRight = new ExpandedNodeId(ThesisServer.Variables.PickAndPlace_XRight, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PickAndPlace_XLeft Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlace_XLeft = new ExpandedNodeId(ThesisServer.Variables.PickAndPlace_XLeft, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PickAndPlace_Pick Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlace_Pick = new ExpandedNodeId(ThesisServer.Variables.PickAndPlace_Pick, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PickAndPlace_Release Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickAndPlace_Release = new ExpandedNodeId(ThesisServer.Variables.PickAndPlace_Release, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Sensor_SSBeltBegin Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sensor_SSBeltBegin = new ExpandedNodeId(ThesisServer.Variables.Sensor_SSBeltBegin, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Sensor_SSBeltEnd Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sensor_SSBeltEnd = new ExpandedNodeId(ThesisServer.Variables.Sensor_SSBeltEnd, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Sensor_SSZUp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sensor_SSZUp = new ExpandedNodeId(ThesisServer.Variables.Sensor_SSZUp, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Sensor_SSZDown Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sensor_SSZDown = new ExpandedNodeId(ThesisServer.Variables.Sensor_SSZDown, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Sensor_SSX0 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sensor_SSX0 = new ExpandedNodeId(ThesisServer.Variables.Sensor_SSX0, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Sensor_SSX1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sensor_SSX1 = new ExpandedNodeId(ThesisServer.Variables.Sensor_SSX1, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Sensor_SSX2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sensor_SSX2 = new ExpandedNodeId(ThesisServer.Variables.Sensor_SSX2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Sensor_SSX3 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sensor_SSX3 = new ExpandedNodeId(ThesisServer.Variables.Sensor_SSX3, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Sensor_SSPusherFront Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sensor_SSPusherFront = new ExpandedNodeId(ThesisServer.Variables.Sensor_SSPusherFront, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Sensor_SSPusherBack Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sensor_SSPusherBack = new ExpandedNodeId(ThesisServer.Variables.Sensor_SSPusherBack, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateType_S0 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateType_S0 = new ExpandedNodeId(ThesisServer.Variables.AutoStateType_S0, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateType_S1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateType_S1 = new ExpandedNodeId(ThesisServer.Variables.AutoStateType_S1, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateType_S2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateType_S2 = new ExpandedNodeId(ThesisServer.Variables.AutoStateType_S2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateType_S3 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateType_S3 = new ExpandedNodeId(ThesisServer.Variables.AutoStateType_S3, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateType_S4 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateType_S4 = new ExpandedNodeId(ThesisServer.Variables.AutoStateType_S4, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateType_S5 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateType_S5 = new ExpandedNodeId(ThesisServer.Variables.AutoStateType_S5, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateType_S6 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateType_S6 = new ExpandedNodeId(ThesisServer.Variables.AutoStateType_S6, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateType_S7 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateType_S7 = new ExpandedNodeId(ThesisServer.Variables.AutoStateType_S7, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateType_S8 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateType_S8 = new ExpandedNodeId(ThesisServer.Variables.AutoStateType_S8, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateType_S9 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateType_S9 = new ExpandedNodeId(ThesisServer.Variables.AutoStateType_S9, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateType_S10 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateType_S10 = new ExpandedNodeId(ThesisServer.Variables.AutoStateType_S10, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateType_S11 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateType_S11 = new ExpandedNodeId(ThesisServer.Variables.AutoStateType_S11, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateType_S12 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateType_S12 = new ExpandedNodeId(ThesisServer.Variables.AutoStateType_S12, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateType_S13 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateType_S13 = new ExpandedNodeId(ThesisServer.Variables.AutoStateType_S13, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Camera_CameraStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Camera_CameraStatus = new ExpandedNodeId(ThesisServer.Variables.Camera_CameraStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Camera_CameraData Variable.
        /// </summary>
        public static readonly ExpandedNodeId Camera_CameraData = new ExpandedNodeId(ThesisServer.Variables.Camera_CameraData, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton_StartButton_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_OperationButton_StartButton_Value = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_OperationButton_StartButton_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton_StopButton_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_OperationButton_StopButton_Value = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_OperationButton_StopButton_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton_ResetButton_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_OperationButton_ResetButton_Value = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_OperationButton_ResetButton_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton_AutoButton_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_OperationButton_AutoButton_Value = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_OperationButton_AutoButton_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton_ManualButton_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_OperationButton_ManualButton_Value = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_OperationButton_ManualButton_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PusherParameters_PushFront Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM_PusherParameters_PushFront = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_ActuatorM_PusherParameters_PushFront, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PusherParameters_PushBack Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM_PusherParameters_PushBack = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_ActuatorM_PusherParameters_PushBack, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_BeltParameters_Belt Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM_BeltParameters_Belt = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_ActuatorM_BeltParameters_Belt, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_ZDown Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_ZDown = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_ZDown, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_ZUp Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_ZUp = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_ZUp, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_XRight Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_XRight = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_XRight, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_XLeft Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_XLeft = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_XLeft, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_Pick Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_Pick = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_Pick, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_Release Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_Release = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceParameters_Release, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorParameters_SSBeltBegin Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_SensorParameters_SSBeltBegin = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_SensorParameters_SSBeltBegin, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorParameters_SSBeltEnd Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_SensorParameters_SSBeltEnd = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_SensorParameters_SSBeltEnd, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorParameters_SSZUp Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_SensorParameters_SSZUp = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_SensorParameters_SSZUp, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorParameters_SSZDown Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_SensorParameters_SSZDown = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_SensorParameters_SSZDown, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorParameters_SSX0 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_SensorParameters_SSX0 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_SensorParameters_SSX0, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorParameters_SSX1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_SensorParameters_SSX1 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_SensorParameters_SSX1, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorParameters_SSX2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_SensorParameters_SSX2 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_SensorParameters_SSX2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorParameters_SSX3 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_SensorParameters_SSX3 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_SensorParameters_SSX3, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorParameters_SSPusherFront Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_SensorParameters_SSPusherFront = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_SensorParameters_SSPusherFront, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorParameters_SSPusherBack Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_SensorParameters_SSPusherBack = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_SensorParameters_SSPusherBack, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S0 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_AutoStateParameters_S0 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_AutoStateParameters_S0, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_AutoStateParameters_S1 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_AutoStateParameters_S1, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_AutoStateParameters_S2 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_AutoStateParameters_S2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S3 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_AutoStateParameters_S3 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_AutoStateParameters_S3, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S4 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_AutoStateParameters_S4 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_AutoStateParameters_S4, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S5 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_AutoStateParameters_S5 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_AutoStateParameters_S5, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S6 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_AutoStateParameters_S6 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_AutoStateParameters_S6, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S7 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_AutoStateParameters_S7 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_AutoStateParameters_S7, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S8 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_AutoStateParameters_S8 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_AutoStateParameters_S8, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S9 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_AutoStateParameters_S9 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_AutoStateParameters_S9, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S10 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_AutoStateParameters_S10 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_AutoStateParameters_S10, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S11 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_AutoStateParameters_S11 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_AutoStateParameters_S11, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S12 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_AutoStateParameters_S12 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_AutoStateParameters_S12, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_AutoStateParameters_S13 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_AutoStateParameters_S13 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_AutoStateParameters_S13, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_CameraParameters_CameraStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_CameraParameters_CameraStatus = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_CameraParameters_CameraStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_CameraParameters_CameraData Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_CameraParameters_CameraData = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_CameraParameters_CameraData, ThesisServer.Namespaces.ThesisServer);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the Ampere component.
        /// </summary>
        public const string Ampere = "Ampere";

        /// <summary>
        /// The BrowseName for the AmpereStatus component.
        /// </summary>
        public const string AmpereStatus = "AmpereStatus";

        /// <summary>
        /// The BrowseName for the AnalogInputType component.
        /// </summary>
        public const string AnalogInputType = "AnalogInputType";

        /// <summary>
        /// The BrowseName for the AnalogOutputType component.
        /// </summary>
        public const string AnalogOutputType = "AnalogOutputType";

        /// <summary>
        /// The BrowseName for the AnalogSensorType component.
        /// </summary>
        public const string AnalogSensorType = "AnalogSensorType";

        /// <summary>
        /// The BrowseName for the AutoStateType component.
        /// </summary>
        public const string AutoStateType = "AutoStateType";

        /// <summary>
        /// The BrowseName for the Belt component.
        /// </summary>
        public const string Belt = "Belt";

        /// <summary>
        /// The BrowseName for the ButtonType component.
        /// </summary>
        public const string ButtonType = "ButtonType";

        /// <summary>
        /// The BrowseName for the Camera component.
        /// </summary>
        public const string Camera = "Camera";

        /// <summary>
        /// The BrowseName for the CameraData component.
        /// </summary>
        public const string CameraData = "CameraData";

        /// <summary>
        /// The BrowseName for the CameraStatus component.
        /// </summary>
        public const string CameraStatus = "CameraStatus";

        /// <summary>
        /// The BrowseName for the Conveyor component.
        /// </summary>
        public const string Conveyor = "Conveyor";

        /// <summary>
        /// The BrowseName for the DigitalType component.
        /// </summary>
        public const string DigitalType = "DigitalType";

        /// <summary>
        /// The BrowseName for the Frequency component.
        /// </summary>
        public const string Frequency = "Frequency";

        /// <summary>
        /// The BrowseName for the GenericControllerType component.
        /// </summary>
        public const string GenericControllerType = "GenericControllerType";

        /// <summary>
        /// The BrowseName for the Input component.
        /// </summary>
        public const string Input = "Input";

        /// <summary>
        /// The BrowseName for the Kd component.
        /// </summary>
        public const string Kd = "Kd";

        /// <summary>
        /// The BrowseName for the Ki component.
        /// </summary>
        public const string Ki = "Ki";

        /// <summary>
        /// The BrowseName for the Kp component.
        /// </summary>
        public const string Kp = "Kp";

        /// <summary>
        /// The BrowseName for the Monitor component.
        /// </summary>
        public const string Monitor = "Monitor";

        /// <summary>
        /// The BrowseName for the OperationButton component.
        /// </summary>
        public const string OperationButton = "Operation Button";

        /// <summary>
        /// The BrowseName for the Output component.
        /// </summary>
        public const string Output = "Output";

        /// <summary>
        /// The BrowseName for the Pick component.
        /// </summary>
        public const string Pick = "Pick";

        /// <summary>
        /// The BrowseName for the PickAndPlace component.
        /// </summary>
        public const string PickAndPlace = "PickAndPlace";

        /// <summary>
        /// The BrowseName for the PLC1214DCDCDC component.
        /// </summary>
        public const string PLC1214DCDCDC = "PLC1214DCDCDC";

        /// <summary>
        /// The BrowseName for the Power component.
        /// </summary>
        public const string Power = "Power";

        /// <summary>
        /// The BrowseName for the PowerFactor component.
        /// </summary>
        public const string PowerFactor = "PowerFactor";

        /// <summary>
        /// The BrowseName for the PowerStatus component.
        /// </summary>
        public const string PowerStatus = "PowerStatus";

        /// <summary>
        /// The BrowseName for the PushBack component.
        /// </summary>
        public const string PushBack = "PushBack";

        /// <summary>
        /// The BrowseName for the Pusher component.
        /// </summary>
        public const string Pusher = "Pusher";

        /// <summary>
        /// The BrowseName for the PushFront component.
        /// </summary>
        public const string PushFront = "PushFront";

        /// <summary>
        /// The BrowseName for the Release component.
        /// </summary>
        public const string Release = "Release";

        /// <summary>
        /// The BrowseName for the S0 component.
        /// </summary>
        public const string S0 = "S0";

        /// <summary>
        /// The BrowseName for the S1 component.
        /// </summary>
        public const string S1 = "S1";

        /// <summary>
        /// The BrowseName for the S10 component.
        /// </summary>
        public const string S10 = "S10";

        /// <summary>
        /// The BrowseName for the S11 component.
        /// </summary>
        public const string S11 = "S11";

        /// <summary>
        /// The BrowseName for the S12 component.
        /// </summary>
        public const string S12 = "S12";

        /// <summary>
        /// The BrowseName for the S13 component.
        /// </summary>
        public const string S13 = "S13";

        /// <summary>
        /// The BrowseName for the S2 component.
        /// </summary>
        public const string S2 = "S2";

        /// <summary>
        /// The BrowseName for the S3 component.
        /// </summary>
        public const string S3 = "S3";

        /// <summary>
        /// The BrowseName for the S4 component.
        /// </summary>
        public const string S4 = "S4";

        /// <summary>
        /// The BrowseName for the S5 component.
        /// </summary>
        public const string S5 = "S5";

        /// <summary>
        /// The BrowseName for the S6 component.
        /// </summary>
        public const string S6 = "S6";

        /// <summary>
        /// The BrowseName for the S7 component.
        /// </summary>
        public const string S7 = "S7";

        /// <summary>
        /// The BrowseName for the S8 component.
        /// </summary>
        public const string S8 = "S8";

        /// <summary>
        /// The BrowseName for the S9 component.
        /// </summary>
        public const string S9 = "S9";

        /// <summary>
        /// The BrowseName for the Sensor component.
        /// </summary>
        public const string Sensor = "Sensor";

        /// <summary>
        /// The BrowseName for the SetPoint component.
        /// </summary>
        public const string SetPoint = "SetPoint";

        /// <summary>
        /// The BrowseName for the SSBeltBegin component.
        /// </summary>
        public const string SSBeltBegin = "SSBeltBegin";

        /// <summary>
        /// The BrowseName for the SSBeltEnd component.
        /// </summary>
        public const string SSBeltEnd = "SSBeltEnd";

        /// <summary>
        /// The BrowseName for the SSPusherBack component.
        /// </summary>
        public const string SSPusherBack = "SSPusherBack";

        /// <summary>
        /// The BrowseName for the SSPusherFront component.
        /// </summary>
        public const string SSPusherFront = "SSPusherFront";

        /// <summary>
        /// The BrowseName for the SSX0 component.
        /// </summary>
        public const string SSX0 = "SSX0";

        /// <summary>
        /// The BrowseName for the SSX1 component.
        /// </summary>
        public const string SSX1 = "SSX1";

        /// <summary>
        /// The BrowseName for the SSX2 component.
        /// </summary>
        public const string SSX2 = "SSX2";

        /// <summary>
        /// The BrowseName for the SSX3 component.
        /// </summary>
        public const string SSX3 = "SSX3";

        /// <summary>
        /// The BrowseName for the SSZDown component.
        /// </summary>
        public const string SSZDown = "SSZDown";

        /// <summary>
        /// The BrowseName for the SSZUp component.
        /// </summary>
        public const string SSZUp = "SSZUp";

        /// <summary>
        /// The BrowseName for the Status component.
        /// </summary>
        public const string Status = "Status";

        /// <summary>
        /// The BrowseName for the Value component.
        /// </summary>
        public const string Value = "Value";

        /// <summary>
        /// The BrowseName for the ValveType component.
        /// </summary>
        public const string ValveType = "ValveType";

        /// <summary>
        /// The BrowseName for the Volt component.
        /// </summary>
        public const string Volt = "Volt";

        /// <summary>
        /// The BrowseName for the VoltStatus component.
        /// </summary>
        public const string VoltStatus = "VoltStatus";

        /// <summary>
        /// The BrowseName for the XLeft component.
        /// </summary>
        public const string XLeft = "XLeft";

        /// <summary>
        /// The BrowseName for the XRight component.
        /// </summary>
        public const string XRight = "XRight";

        /// <summary>
        /// The BrowseName for the ZDown component.
        /// </summary>
        public const string ZDown = "ZDown";

        /// <summary>
        /// The BrowseName for the ZUp component.
        /// </summary>
        public const string ZUp = "ZUp";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the ThesisServer namespace (.NET code namespace is 'ThesisServer').
        /// </summary>
        public const string ThesisServer = "http://opcfoundation.org/ThesisServer";
    }
    #endregion

    #region GenericControllerState Class
    #if (!OPCUA_EXCLUDE_GenericControllerState)
    /// <summary>
    /// Stores an instance of the GenericControllerType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericControllerState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GenericControllerState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.GenericControllerType, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAd" +
           "AAAAR2VuZXJpY0NvbnRyb2xsZXJUeXBlSW5zdGFuY2UBAZk6AQGZOpk6AAD/////BAAAADVgiQoCAAAA" +
           "AQAIAAAAU2V0UG9pbnQBAZo6AwAAAAAQAAAAU2V0UG9pbnQ6IERvdWJsZQAuAESaOgAAAAv/////AwP/" +
           "////AAAAADVgiQoCAAAAAQACAAAAS3ABAZs6AwAAAAAKAAAAS3A6IERvdWJsZQAuAESbOgAAAAv/////" +
           "AwP/////AAAAADVgiQoCAAAAAQACAAAAS2kBAZw6AwAAAAAKAAAAS2k6IERvdWJsZQAuAEScOgAAAAv/" +
           "////AwP/////AAAAADVgiQoCAAAAAQACAAAAS2QBAZ06AwAAAAAKAAAAS2Q6IERvdWJsZQAuAESdOgAA" +
           "AAv/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<double> SetPoint
        {
            get
            {
                return m_setPoint;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setPoint, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setPoint = value;
            }
        }

        /// <remarks />
        public PropertyState<double> Kp
        {
            get
            {
                return m_kp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_kp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_kp = value;
            }
        }

        /// <remarks />
        public PropertyState<double> Ki
        {
            get
            {
                return m_ki;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ki, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ki = value;
            }
        }

        /// <remarks />
        public PropertyState<double> Kd
        {
            get
            {
                return m_kd;
            }

            set
            {
                if (!Object.ReferenceEquals(m_kd, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_kd = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_setPoint != null)
            {
                children.Add(m_setPoint);
            }

            if (m_kp != null)
            {
                children.Add(m_kp);
            }

            if (m_ki != null)
            {
                children.Add(m_ki);
            }

            if (m_kd != null)
            {
                children.Add(m_kd);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case ThesisServer.BrowseNames.SetPoint:
                {
                    if (createOrReplace)
                    {
                        if (SetPoint == null)
                        {
                            if (replacement == null)
                            {
                                SetPoint = new PropertyState<double>(this);
                            }
                            else
                            {
                                SetPoint = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = SetPoint;
                    break;
                }

                case ThesisServer.BrowseNames.Kp:
                {
                    if (createOrReplace)
                    {
                        if (Kp == null)
                        {
                            if (replacement == null)
                            {
                                Kp = new PropertyState<double>(this);
                            }
                            else
                            {
                                Kp = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = Kp;
                    break;
                }

                case ThesisServer.BrowseNames.Ki:
                {
                    if (createOrReplace)
                    {
                        if (Ki == null)
                        {
                            if (replacement == null)
                            {
                                Ki = new PropertyState<double>(this);
                            }
                            else
                            {
                                Ki = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = Ki;
                    break;
                }

                case ThesisServer.BrowseNames.Kd:
                {
                    if (createOrReplace)
                    {
                        if (Kd == null)
                        {
                            if (replacement == null)
                            {
                                Kd = new PropertyState<double>(this);
                            }
                            else
                            {
                                Kd = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = Kd;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<double> m_setPoint;
        private PropertyState<double> m_kp;
        private PropertyState<double> m_ki;
        private PropertyState<double> m_kd;
        #endregion
    }
    #endif
    #endregion

    #region AnalogInputState Class
    #if (!OPCUA_EXCLUDE_AnalogInputState)
    /// <summary>
    /// Stores an instance of the AnalogInputType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogInputState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalogInputState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.AnalogInputType, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAX" +
           "AAAAQW5hbG9nSW5wdXRUeXBlSW5zdGFuY2UBAZ46AQGeOp46AAD/////CgAAADVgiQoCAAAAAQAGAAAA" +
           "T3V0cHV0AQGfOgMAAAAADgAAAE91dHB1dDogRG91YmxlAC8AP586AAAAC/////8DA/////8AAAAANWCJ" +
           "CgIAAAABAAYAAABBbXBlcmUBAaA6AwAAAAAOAAAAQW1wZXJlOiBEb3VibGUALwA/oDoAAAAL/////wMD" +
           "/////wAAAAA1YIkKAgAAAAEADAAAAEFtcGVyZVN0YXR1cwEBoToDAAAAABUAAABBbXBlcmUgc3RhdHVz" +
           "OiBzdHJpbmcALwA/oToAAAAM/////wMD/////wAAAAA1YIkKAgAAAAEABAAAAFZvbHQBAaI6AwAAAAAM" +
           "AAAAVm9sdDogRG91YmxlAC8AP6I6AAAAC/////8DA/////8AAAAANWCJCgIAAAABAAoAAABWb2x0U3Rh" +
           "dHVzAQGjOgMAAAAAEgAAAFZvbHRTdGF0dXM6IHN0cmluZwAvAD+jOgAAAAz/////AwP/////AAAAADVg" +
           "iQoCAAAAAQAJAAAARnJlcXVlbmN5AQGkOgMAAAAAFAAAAEZyZXF1ZW5jeV9IejogRG91YmxlAC8AP6Q6" +
           "AAAAC/////8DA/////8AAAAANWCJCgIAAAABAAUAAABQb3dlcgEBpToDAAAAAA0AAABQb3dlcjogRG91" +
           "YmxlAC8AP6U6AAAAC/////8DA/////8AAAAANWCJCgIAAAABAAsAAABQb3dlclN0YXR1cwEBpjoDAAAA" +
           "ABMAAABQb3dlclN0YXR1czogc3RyaW5nAC8AP6Y6AAAADP////8DA/////8AAAAANWCJCgIAAAABAAsA" +
           "AABQb3dlckZhY3RvcgEBpzoDAAAAABMAAABQb3dlckZhY3RvcjogRG91YmxlAC8AP6c6AAAAC/////8D" +
           "A/////8AAAAANWCJCgIAAAABAAYAAABTdGF0dXMBAag6AwAAAAAPAAAAU3RhdHVzOiBCb29sZWFuAC8A" +
           "P6g6AAAAAf////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<double> Output
        {
            get
            {
                return m_output;
            }

            set
            {
                if (!Object.ReferenceEquals(m_output, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_output = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Ampere
        {
            get
            {
                return m_ampere;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ampere, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ampere = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> AmpereStatus
        {
            get
            {
                return m_ampereStatus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ampereStatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ampereStatus = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Volt
        {
            get
            {
                return m_volt;
            }

            set
            {
                if (!Object.ReferenceEquals(m_volt, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_volt = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> VoltStatus
        {
            get
            {
                return m_voltStatus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_voltStatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_voltStatus = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Frequency
        {
            get
            {
                return m_frequency;
            }

            set
            {
                if (!Object.ReferenceEquals(m_frequency, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_frequency = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Power
        {
            get
            {
                return m_power;
            }

            set
            {
                if (!Object.ReferenceEquals(m_power, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_power = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> PowerStatus
        {
            get
            {
                return m_powerStatus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_powerStatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_powerStatus = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> PowerFactor
        {
            get
            {
                return m_powerFactor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_powerFactor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_powerFactor = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> Status
        {
            get
            {
                return m_status;
            }

            set
            {
                if (!Object.ReferenceEquals(m_status, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_status = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_output != null)
            {
                children.Add(m_output);
            }

            if (m_ampere != null)
            {
                children.Add(m_ampere);
            }

            if (m_ampereStatus != null)
            {
                children.Add(m_ampereStatus);
            }

            if (m_volt != null)
            {
                children.Add(m_volt);
            }

            if (m_voltStatus != null)
            {
                children.Add(m_voltStatus);
            }

            if (m_frequency != null)
            {
                children.Add(m_frequency);
            }

            if (m_power != null)
            {
                children.Add(m_power);
            }

            if (m_powerStatus != null)
            {
                children.Add(m_powerStatus);
            }

            if (m_powerFactor != null)
            {
                children.Add(m_powerFactor);
            }

            if (m_status != null)
            {
                children.Add(m_status);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case ThesisServer.BrowseNames.Output:
                {
                    if (createOrReplace)
                    {
                        if (Output == null)
                        {
                            if (replacement == null)
                            {
                                Output = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Output = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Output;
                    break;
                }

                case ThesisServer.BrowseNames.Ampere:
                {
                    if (createOrReplace)
                    {
                        if (Ampere == null)
                        {
                            if (replacement == null)
                            {
                                Ampere = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Ampere = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Ampere;
                    break;
                }

                case ThesisServer.BrowseNames.AmpereStatus:
                {
                    if (createOrReplace)
                    {
                        if (AmpereStatus == null)
                        {
                            if (replacement == null)
                            {
                                AmpereStatus = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                AmpereStatus = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = AmpereStatus;
                    break;
                }

                case ThesisServer.BrowseNames.Volt:
                {
                    if (createOrReplace)
                    {
                        if (Volt == null)
                        {
                            if (replacement == null)
                            {
                                Volt = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Volt = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Volt;
                    break;
                }

                case ThesisServer.BrowseNames.VoltStatus:
                {
                    if (createOrReplace)
                    {
                        if (VoltStatus == null)
                        {
                            if (replacement == null)
                            {
                                VoltStatus = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                VoltStatus = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = VoltStatus;
                    break;
                }

                case ThesisServer.BrowseNames.Frequency:
                {
                    if (createOrReplace)
                    {
                        if (Frequency == null)
                        {
                            if (replacement == null)
                            {
                                Frequency = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Frequency = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Frequency;
                    break;
                }

                case ThesisServer.BrowseNames.Power:
                {
                    if (createOrReplace)
                    {
                        if (Power == null)
                        {
                            if (replacement == null)
                            {
                                Power = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Power = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Power;
                    break;
                }

                case ThesisServer.BrowseNames.PowerStatus:
                {
                    if (createOrReplace)
                    {
                        if (PowerStatus == null)
                        {
                            if (replacement == null)
                            {
                                PowerStatus = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                PowerStatus = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = PowerStatus;
                    break;
                }

                case ThesisServer.BrowseNames.PowerFactor:
                {
                    if (createOrReplace)
                    {
                        if (PowerFactor == null)
                        {
                            if (replacement == null)
                            {
                                PowerFactor = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                PowerFactor = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = PowerFactor;
                    break;
                }

                case ThesisServer.BrowseNames.Status:
                {
                    if (createOrReplace)
                    {
                        if (Status == null)
                        {
                            if (replacement == null)
                            {
                                Status = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Status = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Status;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<double> m_output;
        private BaseDataVariableState<double> m_ampere;
        private BaseDataVariableState<string> m_ampereStatus;
        private BaseDataVariableState<double> m_volt;
        private BaseDataVariableState<string> m_voltStatus;
        private BaseDataVariableState<double> m_frequency;
        private BaseDataVariableState<double> m_power;
        private BaseDataVariableState<string> m_powerStatus;
        private BaseDataVariableState<double> m_powerFactor;
        private BaseDataVariableState<bool> m_status;
        #endregion
    }
    #endif
    #endregion

    #region AnalogOutputState Class
    #if (!OPCUA_EXCLUDE_AnalogOutputState)
    /// <summary>
    /// Stores an instance of the AnalogOutputType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogOutputState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalogOutputState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.AnalogOutputType, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAY" +
           "AAAAQW5hbG9nT3V0cHV0VHlwZUluc3RhbmNlAQGpOgEBqTqpOgAA/////wEAAAA1YIkKAgAAAAEABQAA" +
           "AElucHV0AQGqOgMAAAAADQAAAElucHV0OiBEb3VibGUALwA/qjoAAAAL/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<double> Input
        {
            get
            {
                return m_input;
            }

            set
            {
                if (!Object.ReferenceEquals(m_input, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_input = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_input != null)
            {
                children.Add(m_input);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case ThesisServer.BrowseNames.Input:
                {
                    if (createOrReplace)
                    {
                        if (Input == null)
                        {
                            if (replacement == null)
                            {
                                Input = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Input = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Input;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<double> m_input;
        #endregion
    }
    #endif
    #endregion

    #region DigitalState Class
    #if (!OPCUA_EXCLUDE_DigitalState)
    /// <summary>
    /// Stores an instance of the DigitalType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DigitalState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DigitalState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.DigitalType, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAT" +
           "AAAARGlnaXRhbFR5cGVJbnN0YW5jZQEBqzoBAas6qzoAAP////8BAAAANWCJCgIAAAABAAUAAABWYWx1" +
           "ZQEBrDoDAAAAAA4AAABWYWx1ZTogQm9vbGVhbgAvAD+sOgAAAAH/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<bool> Value
        {
            get
            {
                return m_value;
            }

            set
            {
                if (!Object.ReferenceEquals(m_value, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_value = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_value != null)
            {
                children.Add(m_value);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case ThesisServer.BrowseNames.Value:
                {
                    if (createOrReplace)
                    {
                        if (Value == null)
                        {
                            if (replacement == null)
                            {
                                Value = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Value = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Value;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<bool> m_value;
        #endregion
    }
    #endif
    #endregion

    #region PusherState Class
    #if (!OPCUA_EXCLUDE_PusherState)
    /// <summary>
    /// Stores an instance of the Pusher ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PusherState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PusherState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.Pusher, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAO" +
           "AAAAUHVzaGVySW5zdGFuY2UBAa06AQGtOq06AAD/////AgAAADVgiQoCAAAAAQAJAAAAUHVzaEZyb250" +
           "AQGuOgMAAAAABAAAAFB1c2gALwA/rjoAAAAB/////wMD/////wAAAAA1YIkKAgAAAAEACAAAAFB1c2hC" +
           "YWNrAQGvOgMAAAAABAAAAFB1bGwALwA/rzoAAAAB/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<bool> PushFront
        {
            get
            {
                return m_pushFront;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pushFront, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pushFront = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> PushBack
        {
            get
            {
                return m_pushBack;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pushBack, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pushBack = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_pushFront != null)
            {
                children.Add(m_pushFront);
            }

            if (m_pushBack != null)
            {
                children.Add(m_pushBack);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case ThesisServer.BrowseNames.PushFront:
                {
                    if (createOrReplace)
                    {
                        if (PushFront == null)
                        {
                            if (replacement == null)
                            {
                                PushFront = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                PushFront = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = PushFront;
                    break;
                }

                case ThesisServer.BrowseNames.PushBack:
                {
                    if (createOrReplace)
                    {
                        if (PushBack == null)
                        {
                            if (replacement == null)
                            {
                                PushBack = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                PushBack = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = PushBack;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<bool> m_pushFront;
        private BaseDataVariableState<bool> m_pushBack;
        #endregion
    }
    #endif
    #endregion

    #region ConveyorState Class
    #if (!OPCUA_EXCLUDE_ConveyorState)
    /// <summary>
    /// Stores an instance of the Conveyor ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConveyorState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConveyorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.Conveyor, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAQ" +
           "AAAAQ29udmV5b3JJbnN0YW5jZQEBsDoBAbA6sDoAAP////8BAAAANWCJCgIAAAABAAQAAABCZWx0AQGx" +
           "OgMAAAAABAAAAEJlbHQALwA/sToAAAAB/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<bool> Belt
        {
            get
            {
                return m_belt;
            }

            set
            {
                if (!Object.ReferenceEquals(m_belt, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_belt = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_belt != null)
            {
                children.Add(m_belt);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case ThesisServer.BrowseNames.Belt:
                {
                    if (createOrReplace)
                    {
                        if (Belt == null)
                        {
                            if (replacement == null)
                            {
                                Belt = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Belt = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Belt;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<bool> m_belt;
        #endregion
    }
    #endif
    #endregion

    #region PickAndPlaceState Class
    #if (!OPCUA_EXCLUDE_PickAndPlaceState)
    /// <summary>
    /// Stores an instance of the PickAndPlace ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PickAndPlaceState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PickAndPlaceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.PickAndPlace, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAU" +
           "AAAAUGlja0FuZFBsYWNlSW5zdGFuY2UBAbI6AQGyOrI6AAD/////BgAAADVgiQoCAAAAAQAFAAAAWkRv" +
           "d24BAbM6AwAAAAAEAAAARG93bgAvAD+zOgAAAAH/////AwP/////AAAAADVgiQoCAAAAAQADAAAAWlVw" +
           "AQG0OgMAAAAAAgAAAFVwAC8AP7Q6AAAAAf////8DA/////8AAAAANWCJCgIAAAABAAYAAABYUmlnaHQB" +
           "AbU6AwAAAAAFAAAAUmlnaHQALwA/tToAAAAB/////wMD/////wAAAAA1YIkKAgAAAAEABQAAAFhMZWZ0" +
           "AQG2OgMAAAAABAAAAExlZnQALwA/tjoAAAAB/////wMD/////wAAAAA1YIkKAgAAAAEABAAAAFBpY2sB" +
           "Abc6AwAAAAAEAAAAUGljawAvAD+3OgAAAAH/////AwP/////AAAAADVgiQoCAAAAAQAHAAAAUmVsZWFz" +
           "ZQEBuDoDAAAAAAcAAABSZWxlYXNlAC8AP7g6AAAAAf////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<bool> ZDown
        {
            get
            {
                return m_zDown;
            }

            set
            {
                if (!Object.ReferenceEquals(m_zDown, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_zDown = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> ZUp
        {
            get
            {
                return m_zUp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_zUp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_zUp = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> XRight
        {
            get
            {
                return m_xRight;
            }

            set
            {
                if (!Object.ReferenceEquals(m_xRight, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_xRight = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> XLeft
        {
            get
            {
                return m_xLeft;
            }

            set
            {
                if (!Object.ReferenceEquals(m_xLeft, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_xLeft = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> Pick
        {
            get
            {
                return m_pick;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pick, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pick = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> Release
        {
            get
            {
                return m_release;
            }

            set
            {
                if (!Object.ReferenceEquals(m_release, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_release = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_zDown != null)
            {
                children.Add(m_zDown);
            }

            if (m_zUp != null)
            {
                children.Add(m_zUp);
            }

            if (m_xRight != null)
            {
                children.Add(m_xRight);
            }

            if (m_xLeft != null)
            {
                children.Add(m_xLeft);
            }

            if (m_pick != null)
            {
                children.Add(m_pick);
            }

            if (m_release != null)
            {
                children.Add(m_release);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case ThesisServer.BrowseNames.ZDown:
                {
                    if (createOrReplace)
                    {
                        if (ZDown == null)
                        {
                            if (replacement == null)
                            {
                                ZDown = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                ZDown = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = ZDown;
                    break;
                }

                case ThesisServer.BrowseNames.ZUp:
                {
                    if (createOrReplace)
                    {
                        if (ZUp == null)
                        {
                            if (replacement == null)
                            {
                                ZUp = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                ZUp = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = ZUp;
                    break;
                }

                case ThesisServer.BrowseNames.XRight:
                {
                    if (createOrReplace)
                    {
                        if (XRight == null)
                        {
                            if (replacement == null)
                            {
                                XRight = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                XRight = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = XRight;
                    break;
                }

                case ThesisServer.BrowseNames.XLeft:
                {
                    if (createOrReplace)
                    {
                        if (XLeft == null)
                        {
                            if (replacement == null)
                            {
                                XLeft = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                XLeft = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = XLeft;
                    break;
                }

                case ThesisServer.BrowseNames.Pick:
                {
                    if (createOrReplace)
                    {
                        if (Pick == null)
                        {
                            if (replacement == null)
                            {
                                Pick = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Pick = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Pick;
                    break;
                }

                case ThesisServer.BrowseNames.Release:
                {
                    if (createOrReplace)
                    {
                        if (Release == null)
                        {
                            if (replacement == null)
                            {
                                Release = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Release = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Release;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<bool> m_zDown;
        private BaseDataVariableState<bool> m_zUp;
        private BaseDataVariableState<bool> m_xRight;
        private BaseDataVariableState<bool> m_xLeft;
        private BaseDataVariableState<bool> m_pick;
        private BaseDataVariableState<bool> m_release;
        #endregion
    }
    #endif
    #endregion

    #region SensorState Class
    #if (!OPCUA_EXCLUDE_SensorState)
    /// <summary>
    /// Stores an instance of the Sensor ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SensorState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SensorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.Sensor, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAO" +
           "AAAAU2Vuc29ySW5zdGFuY2UBAbk6AQG5Ork6AAD/////CgAAADVgiQoCAAAAAQALAAAAU1NCZWx0QmVn" +
           "aW4BAbo6AwAAAAALAAAAU1NCZWx0QmVnaW4ALwA/ujoAAAAB/////wMD/////wAAAAA1YIkKAgAAAAEA" +
           "CQAAAFNTQmVsdEVuZAEBuzoDAAAAAAkAAABTU0JlbHRFbmQALwA/uzoAAAAB/////wMD/////wAAAAA1" +
           "YIkKAgAAAAEABQAAAFNTWlVwAQG8OgMAAAAABQAAAFNTWlVwAC8AP7w6AAAAAf////8DA/////8AAAAA" +
           "NWCJCgIAAAABAAcAAABTU1pEb3duAQG9OgMAAAAABwAAAFNTWkRvd24ALwA/vToAAAAB/////wMD////" +
           "/wAAAAA1YIkKAgAAAAEABAAAAFNTWDABAb46AwAAAAAEAAAAU1NYMAAvAD++OgAAAAH/////AwP/////" +
           "AAAAADVgiQoCAAAAAQAEAAAAU1NYMQEBvzoDAAAAAAQAAABTU1gxAC8AP786AAAAAf////8DA/////8A" +
           "AAAANWCJCgIAAAABAAQAAABTU1gyAQHAOgMAAAAABAAAAFNTWDIALwA/wDoAAAAB/////wMD/////wAA" +
           "AAA1YIkKAgAAAAEABAAAAFNTWDMBAcE6AwAAAAAEAAAAU1NYMwAvAD/BOgAAAAH/////AwP/////AAAA" +
           "ADVgiQoCAAAAAQANAAAAU1NQdXNoZXJGcm9udAEBwjoDAAAAAAQAAABTU1gzAC8AP8I6AAAAAf////8D" +
           "A/////8AAAAANWCJCgIAAAABAAwAAABTU1B1c2hlckJhY2sBAcM6AwAAAAAEAAAAU1NYMwAvAD/DOgAA" +
           "AAH/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<bool> SSBeltBegin
        {
            get
            {
                return m_sSBeltBegin;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sSBeltBegin, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sSBeltBegin = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> SSBeltEnd
        {
            get
            {
                return m_sSBeltEnd;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sSBeltEnd, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sSBeltEnd = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> SSZUp
        {
            get
            {
                return m_sSZUp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sSZUp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sSZUp = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> SSZDown
        {
            get
            {
                return m_sSZDown;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sSZDown, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sSZDown = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> SSX0
        {
            get
            {
                return m_sSX0;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sSX0, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sSX0 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> SSX1
        {
            get
            {
                return m_sSX1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sSX1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sSX1 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> SSX2
        {
            get
            {
                return m_sSX2;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sSX2, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sSX2 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> SSX3
        {
            get
            {
                return m_sSX3;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sSX3, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sSX3 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> SSPusherFront
        {
            get
            {
                return m_sSPusherFront;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sSPusherFront, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sSPusherFront = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> SSPusherBack
        {
            get
            {
                return m_sSPusherBack;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sSPusherBack, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sSPusherBack = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_sSBeltBegin != null)
            {
                children.Add(m_sSBeltBegin);
            }

            if (m_sSBeltEnd != null)
            {
                children.Add(m_sSBeltEnd);
            }

            if (m_sSZUp != null)
            {
                children.Add(m_sSZUp);
            }

            if (m_sSZDown != null)
            {
                children.Add(m_sSZDown);
            }

            if (m_sSX0 != null)
            {
                children.Add(m_sSX0);
            }

            if (m_sSX1 != null)
            {
                children.Add(m_sSX1);
            }

            if (m_sSX2 != null)
            {
                children.Add(m_sSX2);
            }

            if (m_sSX3 != null)
            {
                children.Add(m_sSX3);
            }

            if (m_sSPusherFront != null)
            {
                children.Add(m_sSPusherFront);
            }

            if (m_sSPusherBack != null)
            {
                children.Add(m_sSPusherBack);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case ThesisServer.BrowseNames.SSBeltBegin:
                {
                    if (createOrReplace)
                    {
                        if (SSBeltBegin == null)
                        {
                            if (replacement == null)
                            {
                                SSBeltBegin = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                SSBeltBegin = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = SSBeltBegin;
                    break;
                }

                case ThesisServer.BrowseNames.SSBeltEnd:
                {
                    if (createOrReplace)
                    {
                        if (SSBeltEnd == null)
                        {
                            if (replacement == null)
                            {
                                SSBeltEnd = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                SSBeltEnd = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = SSBeltEnd;
                    break;
                }

                case ThesisServer.BrowseNames.SSZUp:
                {
                    if (createOrReplace)
                    {
                        if (SSZUp == null)
                        {
                            if (replacement == null)
                            {
                                SSZUp = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                SSZUp = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = SSZUp;
                    break;
                }

                case ThesisServer.BrowseNames.SSZDown:
                {
                    if (createOrReplace)
                    {
                        if (SSZDown == null)
                        {
                            if (replacement == null)
                            {
                                SSZDown = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                SSZDown = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = SSZDown;
                    break;
                }

                case ThesisServer.BrowseNames.SSX0:
                {
                    if (createOrReplace)
                    {
                        if (SSX0 == null)
                        {
                            if (replacement == null)
                            {
                                SSX0 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                SSX0 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = SSX0;
                    break;
                }

                case ThesisServer.BrowseNames.SSX1:
                {
                    if (createOrReplace)
                    {
                        if (SSX1 == null)
                        {
                            if (replacement == null)
                            {
                                SSX1 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                SSX1 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = SSX1;
                    break;
                }

                case ThesisServer.BrowseNames.SSX2:
                {
                    if (createOrReplace)
                    {
                        if (SSX2 == null)
                        {
                            if (replacement == null)
                            {
                                SSX2 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                SSX2 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = SSX2;
                    break;
                }

                case ThesisServer.BrowseNames.SSX3:
                {
                    if (createOrReplace)
                    {
                        if (SSX3 == null)
                        {
                            if (replacement == null)
                            {
                                SSX3 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                SSX3 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = SSX3;
                    break;
                }

                case ThesisServer.BrowseNames.SSPusherFront:
                {
                    if (createOrReplace)
                    {
                        if (SSPusherFront == null)
                        {
                            if (replacement == null)
                            {
                                SSPusherFront = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                SSPusherFront = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = SSPusherFront;
                    break;
                }

                case ThesisServer.BrowseNames.SSPusherBack:
                {
                    if (createOrReplace)
                    {
                        if (SSPusherBack == null)
                        {
                            if (replacement == null)
                            {
                                SSPusherBack = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                SSPusherBack = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = SSPusherBack;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<bool> m_sSBeltBegin;
        private BaseDataVariableState<bool> m_sSBeltEnd;
        private BaseDataVariableState<bool> m_sSZUp;
        private BaseDataVariableState<bool> m_sSZDown;
        private BaseDataVariableState<bool> m_sSX0;
        private BaseDataVariableState<bool> m_sSX1;
        private BaseDataVariableState<bool> m_sSX2;
        private BaseDataVariableState<bool> m_sSX3;
        private BaseDataVariableState<bool> m_sSPusherFront;
        private BaseDataVariableState<bool> m_sSPusherBack;
        #endregion
    }
    #endif
    #endregion

    #region AutoStateState Class
    #if (!OPCUA_EXCLUDE_AutoStateState)
    /// <summary>
    /// Stores an instance of the AutoStateType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AutoStateState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AutoStateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.AutoStateType, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAV" +
           "AAAAQXV0b1N0YXRlVHlwZUluc3RhbmNlAQHEOgEBxDrEOgAA/////w4AAAA1YIkKAgAAAAEAAgAAAFMw" +
           "AQHFOgMAAAAAAgAAAFMwAC8AP8U6AAAAAf////8DA/////8AAAAANWCJCgIAAAABAAIAAABTMQEBxjoD" +
           "AAAAAAIAAABTMQAvAD/GOgAAAAH/////AwP/////AAAAADVgiQoCAAAAAQACAAAAUzIBAcc6AwAAAAAC" +
           "AAAAUzIALwA/xzoAAAAB/////wMD/////wAAAAA1YIkKAgAAAAEAAgAAAFMzAQHIOgMAAAAAAgAAAFMz" +
           "AC8AP8g6AAAAAf////8DA/////8AAAAANWCJCgIAAAABAAIAAABTNAEByToDAAAAAAIAAABTNAAvAD/J" +
           "OgAAAAH/////AwP/////AAAAADVgiQoCAAAAAQACAAAAUzUBAco6AwAAAAACAAAAUzUALwA/yjoAAAAB" +
           "/////wMD/////wAAAAA1YIkKAgAAAAEAAgAAAFM2AQHLOgMAAAAAAgAAAFM2AC8AP8s6AAAAAf////8D" +
           "A/////8AAAAANWCJCgIAAAABAAIAAABTNwEBzDoDAAAAAAIAAABTNwAvAD/MOgAAAAH/////AwP/////" +
           "AAAAADVgiQoCAAAAAQACAAAAUzgBAc06AwAAAAACAAAAUzgALwA/zToAAAAB/////wMD/////wAAAAA1" +
           "YIkKAgAAAAEAAgAAAFM5AQHOOgMAAAAAAgAAAFM5AC8AP846AAAAAf////8DA/////8AAAAANWCJCgIA" +
           "AAABAAMAAABTMTABAc86AwAAAAADAAAAUzEwAC8AP886AAAAAf////8DA/////8AAAAANWCJCgIAAAAB" +
           "AAMAAABTMTEBAdA6AwAAAAADAAAAUzExAC8AP9A6AAAAAf////8DA/////8AAAAANWCJCgIAAAABAAMA" +
           "AABTMTIBAdE6AwAAAAADAAAAUzEyAC8AP9E6AAAAAf////8DA/////8AAAAANWCJCgIAAAABAAMAAABT" +
           "MTMBAdI6AwAAAAADAAAAUzEzAC8AP9I6AAAAAf////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<bool> S0
        {
            get
            {
                return m_s0;
            }

            set
            {
                if (!Object.ReferenceEquals(m_s0, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_s0 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> S1
        {
            get
            {
                return m_s1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_s1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_s1 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> S2
        {
            get
            {
                return m_s2;
            }

            set
            {
                if (!Object.ReferenceEquals(m_s2, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_s2 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> S3
        {
            get
            {
                return m_s3;
            }

            set
            {
                if (!Object.ReferenceEquals(m_s3, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_s3 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> S4
        {
            get
            {
                return m_s4;
            }

            set
            {
                if (!Object.ReferenceEquals(m_s4, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_s4 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> S5
        {
            get
            {
                return m_s5;
            }

            set
            {
                if (!Object.ReferenceEquals(m_s5, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_s5 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> S6
        {
            get
            {
                return m_s6;
            }

            set
            {
                if (!Object.ReferenceEquals(m_s6, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_s6 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> S7
        {
            get
            {
                return m_s7;
            }

            set
            {
                if (!Object.ReferenceEquals(m_s7, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_s7 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> S8
        {
            get
            {
                return m_s8;
            }

            set
            {
                if (!Object.ReferenceEquals(m_s8, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_s8 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> S9
        {
            get
            {
                return m_s9;
            }

            set
            {
                if (!Object.ReferenceEquals(m_s9, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_s9 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> S10
        {
            get
            {
                return m_s10;
            }

            set
            {
                if (!Object.ReferenceEquals(m_s10, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_s10 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> S11
        {
            get
            {
                return m_s11;
            }

            set
            {
                if (!Object.ReferenceEquals(m_s11, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_s11 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> S12
        {
            get
            {
                return m_s12;
            }

            set
            {
                if (!Object.ReferenceEquals(m_s12, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_s12 = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> S13
        {
            get
            {
                return m_s13;
            }

            set
            {
                if (!Object.ReferenceEquals(m_s13, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_s13 = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_s0 != null)
            {
                children.Add(m_s0);
            }

            if (m_s1 != null)
            {
                children.Add(m_s1);
            }

            if (m_s2 != null)
            {
                children.Add(m_s2);
            }

            if (m_s3 != null)
            {
                children.Add(m_s3);
            }

            if (m_s4 != null)
            {
                children.Add(m_s4);
            }

            if (m_s5 != null)
            {
                children.Add(m_s5);
            }

            if (m_s6 != null)
            {
                children.Add(m_s6);
            }

            if (m_s7 != null)
            {
                children.Add(m_s7);
            }

            if (m_s8 != null)
            {
                children.Add(m_s8);
            }

            if (m_s9 != null)
            {
                children.Add(m_s9);
            }

            if (m_s10 != null)
            {
                children.Add(m_s10);
            }

            if (m_s11 != null)
            {
                children.Add(m_s11);
            }

            if (m_s12 != null)
            {
                children.Add(m_s12);
            }

            if (m_s13 != null)
            {
                children.Add(m_s13);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case ThesisServer.BrowseNames.S0:
                {
                    if (createOrReplace)
                    {
                        if (S0 == null)
                        {
                            if (replacement == null)
                            {
                                S0 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                S0 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = S0;
                    break;
                }

                case ThesisServer.BrowseNames.S1:
                {
                    if (createOrReplace)
                    {
                        if (S1 == null)
                        {
                            if (replacement == null)
                            {
                                S1 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                S1 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = S1;
                    break;
                }

                case ThesisServer.BrowseNames.S2:
                {
                    if (createOrReplace)
                    {
                        if (S2 == null)
                        {
                            if (replacement == null)
                            {
                                S2 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                S2 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = S2;
                    break;
                }

                case ThesisServer.BrowseNames.S3:
                {
                    if (createOrReplace)
                    {
                        if (S3 == null)
                        {
                            if (replacement == null)
                            {
                                S3 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                S3 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = S3;
                    break;
                }

                case ThesisServer.BrowseNames.S4:
                {
                    if (createOrReplace)
                    {
                        if (S4 == null)
                        {
                            if (replacement == null)
                            {
                                S4 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                S4 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = S4;
                    break;
                }

                case ThesisServer.BrowseNames.S5:
                {
                    if (createOrReplace)
                    {
                        if (S5 == null)
                        {
                            if (replacement == null)
                            {
                                S5 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                S5 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = S5;
                    break;
                }

                case ThesisServer.BrowseNames.S6:
                {
                    if (createOrReplace)
                    {
                        if (S6 == null)
                        {
                            if (replacement == null)
                            {
                                S6 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                S6 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = S6;
                    break;
                }

                case ThesisServer.BrowseNames.S7:
                {
                    if (createOrReplace)
                    {
                        if (S7 == null)
                        {
                            if (replacement == null)
                            {
                                S7 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                S7 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = S7;
                    break;
                }

                case ThesisServer.BrowseNames.S8:
                {
                    if (createOrReplace)
                    {
                        if (S8 == null)
                        {
                            if (replacement == null)
                            {
                                S8 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                S8 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = S8;
                    break;
                }

                case ThesisServer.BrowseNames.S9:
                {
                    if (createOrReplace)
                    {
                        if (S9 == null)
                        {
                            if (replacement == null)
                            {
                                S9 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                S9 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = S9;
                    break;
                }

                case ThesisServer.BrowseNames.S10:
                {
                    if (createOrReplace)
                    {
                        if (S10 == null)
                        {
                            if (replacement == null)
                            {
                                S10 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                S10 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = S10;
                    break;
                }

                case ThesisServer.BrowseNames.S11:
                {
                    if (createOrReplace)
                    {
                        if (S11 == null)
                        {
                            if (replacement == null)
                            {
                                S11 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                S11 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = S11;
                    break;
                }

                case ThesisServer.BrowseNames.S12:
                {
                    if (createOrReplace)
                    {
                        if (S12 == null)
                        {
                            if (replacement == null)
                            {
                                S12 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                S12 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = S12;
                    break;
                }

                case ThesisServer.BrowseNames.S13:
                {
                    if (createOrReplace)
                    {
                        if (S13 == null)
                        {
                            if (replacement == null)
                            {
                                S13 = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                S13 = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = S13;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<bool> m_s0;
        private BaseDataVariableState<bool> m_s1;
        private BaseDataVariableState<bool> m_s2;
        private BaseDataVariableState<bool> m_s3;
        private BaseDataVariableState<bool> m_s4;
        private BaseDataVariableState<bool> m_s5;
        private BaseDataVariableState<bool> m_s6;
        private BaseDataVariableState<bool> m_s7;
        private BaseDataVariableState<bool> m_s8;
        private BaseDataVariableState<bool> m_s9;
        private BaseDataVariableState<bool> m_s10;
        private BaseDataVariableState<bool> m_s11;
        private BaseDataVariableState<bool> m_s12;
        private BaseDataVariableState<bool> m_s13;
        #endregion
    }
    #endif
    #endregion

    #region CameraState Class
    #if (!OPCUA_EXCLUDE_CameraState)
    /// <summary>
    /// Stores an instance of the Camera ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CameraState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CameraState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.Camera, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAO" +
           "AAAAQ2FtZXJhSW5zdGFuY2UBAdM6AQHTOtM6AAD/////AgAAADVgiQoCAAAAAQAMAAAAQ2FtZXJhU3Rh" +
           "dHVzAQHUOgMAAAAADAAAAENhbWVyYSBTdGF0ZQAvAD/UOgAAAAH/////AwP/////AAAAADVgiQoCAAAA" +
           "AQAKAAAAQ2FtZXJhRGF0YQEB1ToDAAAAAAsAAABDYW1lcmEgRGF0YQAvAD/VOgAAAAz/////AwP/////" +
           "AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<bool> CameraStatus
        {
            get
            {
                return m_cameraStatus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cameraStatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cameraStatus = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> CameraData
        {
            get
            {
                return m_cameraData;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cameraData, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cameraData = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_cameraStatus != null)
            {
                children.Add(m_cameraStatus);
            }

            if (m_cameraData != null)
            {
                children.Add(m_cameraData);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case ThesisServer.BrowseNames.CameraStatus:
                {
                    if (createOrReplace)
                    {
                        if (CameraStatus == null)
                        {
                            if (replacement == null)
                            {
                                CameraStatus = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                CameraStatus = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = CameraStatus;
                    break;
                }

                case ThesisServer.BrowseNames.CameraData:
                {
                    if (createOrReplace)
                    {
                        if (CameraData == null)
                        {
                            if (replacement == null)
                            {
                                CameraData = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                CameraData = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = CameraData;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<bool> m_cameraStatus;
        private BaseDataVariableState<string> m_cameraData;
        #endregion
    }
    #endif
    #endregion

    #region ValveState Class
    #if (!OPCUA_EXCLUDE_ValveState)
    /// <summary>
    /// Stores an instance of the ValveType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ValveState : AnalogOutputState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ValveState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.ValveType, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAR" +
           "AAAAVmFsdmVUeXBlSW5zdGFuY2UBAdY6AQHWOtY6AAD/////AQAAADVgiQoCAAAAAQAFAAAASW5wdXQB" +
           "Adc6AwAAAAANAAAASW5wdXQ6IERvdWJsZQAvAD/XOgAAAAv/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region AnalogSensorState Class
    #if (!OPCUA_EXCLUDE_AnalogSensorState)
    /// <summary>
    /// Stores an instance of the AnalogSensorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogSensorState : AnalogInputState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalogSensorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.AnalogSensorType, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAY" +
           "AAAAQW5hbG9nU2Vuc29yVHlwZUluc3RhbmNlAQHYOgEB2DrYOgAA/////woAAAA1YIkKAgAAAAEABgAA" +
           "AE91dHB1dAEB2ToDAAAAAA4AAABPdXRwdXQ6IERvdWJsZQAvAD/ZOgAAAAv/////AwP/////AAAAADVg" +
           "iQoCAAAAAQAGAAAAQW1wZXJlAQHaOgMAAAAADgAAAEFtcGVyZTogRG91YmxlAC8AP9o6AAAAC/////8D" +
           "A/////8AAAAANWCJCgIAAAABAAwAAABBbXBlcmVTdGF0dXMBAds6AwAAAAAVAAAAQW1wZXJlIHN0YXR1" +
           "czogc3RyaW5nAC8AP9s6AAAADP////8DA/////8AAAAANWCJCgIAAAABAAQAAABWb2x0AQHcOgMAAAAA" +
           "DAAAAFZvbHQ6IERvdWJsZQAvAD/cOgAAAAv/////AwP/////AAAAADVgiQoCAAAAAQAKAAAAVm9sdFN0" +
           "YXR1cwEB3ToDAAAAABIAAABWb2x0U3RhdHVzOiBzdHJpbmcALwA/3ToAAAAM/////wMD/////wAAAAA1" +
           "YIkKAgAAAAEACQAAAEZyZXF1ZW5jeQEB3joDAAAAABQAAABGcmVxdWVuY3lfSHo6IERvdWJsZQAvAD/e" +
           "OgAAAAv/////AwP/////AAAAADVgiQoCAAAAAQAFAAAAUG93ZXIBAd86AwAAAAANAAAAUG93ZXI6IERv" +
           "dWJsZQAvAD/fOgAAAAv/////AwP/////AAAAADVgiQoCAAAAAQALAAAAUG93ZXJTdGF0dXMBAeA6AwAA" +
           "AAATAAAAUG93ZXJTdGF0dXM6IHN0cmluZwAvAD/gOgAAAAz/////AwP/////AAAAADVgiQoCAAAAAQAL" +
           "AAAAUG93ZXJGYWN0b3IBAeE6AwAAAAATAAAAUG93ZXJGYWN0b3I6IERvdWJsZQAvAD/hOgAAAAv/////" +
           "AwP/////AAAAADVgiQoCAAAAAQAGAAAAU3RhdHVzAQHiOgMAAAAADwAAAFN0YXR1czogQm9vbGVhbgAv" +
           "AD/iOgAAAAH/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ButtonState Class
    #if (!OPCUA_EXCLUDE_ButtonState)
    /// <summary>
    /// Stores an instance of the ButtonType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ButtonState : DigitalState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ButtonState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ThesisServer.ObjectTypes.ButtonType, ThesisServer.Namespaces.ThesisServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGhlc2lzU2VydmVy/////wRggAIBAAAAAQAS" +
           "AAAAQnV0dG9uVHlwZUluc3RhbmNlAQHjOgEB4zrjOgAA/////wEAAAA1YIkKAgAAAAEABQAAAFZhbHVl" +
           "AQHkOgMAAAAADgAAAFZhbHVlOiBCb29sZWFuAC8AP+Q6AAAAAf////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion
}