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
using System.Reflection;
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
        /// The identifier for the Plant1 Object.
        /// </summary>
        public const uint Plant1 = 15073;

        /// <summary>
        /// The identifier for the Plant1_System1 Object.
        /// </summary>
        public const uint Plant1_System1 = 15074;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice Object.
        /// </summary>
        public const uint Plant1_System1_OperationDevice = 15075;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200 Object.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200 = 15076;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters Object.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters = 15077;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100 Object.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100 = 15088;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters Object.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters = 15089;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton Object.
        /// </summary>
        public const uint Plant1_System1_OperationButton = 15100;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_StartButton Object.
        /// </summary>
        public const uint Plant1_System1_OperationButton_StartButton = 15101;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_StopButton Object.
        /// </summary>
        public const uint Plant1_System1_OperationButton_StopButton = 15103;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_ResetButton Object.
        /// </summary>
        public const uint Plant1_System1_OperationButton_ResetButton = 15105;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_ModeButton Object.
        /// </summary>
        public const uint Plant1_System1_OperationButton_ModeButton = 15107;

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController Object.
        /// </summary>
        public const uint Plant1_System1_SpeedController = 15109;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC Object.
        /// </summary>
        public const uint PLC1214DCDCDC = 15114;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton2 Object.
        /// </summary>
        public const uint PLC1214DCDCDC_OperationButton2 = 15115;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton2_StartButton2 Object.
        /// </summary>
        public const uint PLC1214DCDCDC_OperationButton2_StartButton2 = 15116;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton2_StopButton2 Object.
        /// </summary>
        public const uint PLC1214DCDCDC_OperationButton2_StopButton2 = 15118;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton2_ResetButton2 Object.
        /// </summary>
        public const uint PLC1214DCDCDC_OperationButton2_ResetButton2 = 15120;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton2_AutoButton2 Object.
        /// </summary>
        public const uint PLC1214DCDCDC_OperationButton2_AutoButton2 = 15122;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton2_ManualButton2 Object.
        /// </summary>
        public const uint PLC1214DCDCDC_OperationButton2_ManualButton2 = 15124;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController Object.
        /// </summary>
        public const uint PLC1214DCDCDC_ManualController = 15126;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_Pusher2 Object.
        /// </summary>
        public const uint PLC1214DCDCDC_ManualController_Pusher2 = 15127;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_Pusher2_PushFront2 Object.
        /// </summary>
        public const uint PLC1214DCDCDC_ManualController_Pusher2_PushFront2 = 15128;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_Pusher2_PushBack2 Object.
        /// </summary>
        public const uint PLC1214DCDCDC_ManualController_Pusher2_PushBack2 = 15130;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_Belt2 Object.
        /// </summary>
        public const uint PLC1214DCDCDC_ManualController_Belt2 = 15132;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2 Object.
        /// </summary>
        public const uint PLC1214DCDCDC_ManualController_PickAndPlace2 = 15134;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2_ZDown2 Object.
        /// </summary>
        public const uint PLC1214DCDCDC_ManualController_PickAndPlace2_ZDown2 = 15135;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2_ZUp2 Object.
        /// </summary>
        public const uint PLC1214DCDCDC_ManualController_PickAndPlace2_ZUp2 = 15137;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2_XRight2 Object.
        /// </summary>
        public const uint PLC1214DCDCDC_ManualController_PickAndPlace2_XRight2 = 15139;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2_XLeft2 Object.
        /// </summary>
        public const uint PLC1214DCDCDC_ManualController_PickAndPlace2_XLeft2 = 15141;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2_Pick2 Object.
        /// </summary>
        public const uint PLC1214DCDCDC_ManualController_PickAndPlace2_Pick2 = 15143;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2_Release2 Object.
        /// </summary>
        public const uint PLC1214DCDCDC_ManualController_PickAndPlace2_Release2 = 15145;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor Object.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor = 15147;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM Object.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM = 15148;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PusherM Object.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM_PusherM = 15149;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_BeltM Object.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM_BeltM = 15152;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM Object.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM = 15154;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorM Object.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_SensorM = 15161;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters Object.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_StateParameters = 15170;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_CameraM Object.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_CameraM = 15183;
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
        /// The identifier for the AutoStateObject ObjectType.
        /// </summary>
        public const uint AutoStateObject = 15042;

        /// <summary>
        /// The identifier for the CameraObject ObjectType.
        /// </summary>
        public const uint CameraObject = 15055;

        /// <summary>
        /// The identifier for the ValveType ObjectType.
        /// </summary>
        public const uint ValveType = 15058;

        /// <summary>
        /// The identifier for the AnalogSensorType ObjectType.
        /// </summary>
        public const uint AnalogSensorType = 15060;

        /// <summary>
        /// The identifier for the ButtonType ObjectType.
        /// </summary>
        public const uint ButtonType = 15071;
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
        /// The identifier for the AutoStateObject_S0 Variable.
        /// </summary>
        public const uint AutoStateObject_S0 = 15043;

        /// <summary>
        /// The identifier for the AutoStateObject_S1 Variable.
        /// </summary>
        public const uint AutoStateObject_S1 = 15044;

        /// <summary>
        /// The identifier for the AutoStateObject_S2 Variable.
        /// </summary>
        public const uint AutoStateObject_S2 = 15045;

        /// <summary>
        /// The identifier for the AutoStateObject_S3 Variable.
        /// </summary>
        public const uint AutoStateObject_S3 = 15046;

        /// <summary>
        /// The identifier for the AutoStateObject_S4 Variable.
        /// </summary>
        public const uint AutoStateObject_S4 = 15047;

        /// <summary>
        /// The identifier for the AutoStateObject_S5 Variable.
        /// </summary>
        public const uint AutoStateObject_S5 = 15048;

        /// <summary>
        /// The identifier for the AutoStateObject_S6 Variable.
        /// </summary>
        public const uint AutoStateObject_S6 = 15049;

        /// <summary>
        /// The identifier for the AutoStateObject_S7 Variable.
        /// </summary>
        public const uint AutoStateObject_S7 = 15050;

        /// <summary>
        /// The identifier for the AutoStateObject_S8 Variable.
        /// </summary>
        public const uint AutoStateObject_S8 = 15051;

        /// <summary>
        /// The identifier for the AutoStateObject_S9 Variable.
        /// </summary>
        public const uint AutoStateObject_S9 = 15052;

        /// <summary>
        /// The identifier for the AutoStateObject_S10 Variable.
        /// </summary>
        public const uint AutoStateObject_S10 = 15053;

        /// <summary>
        /// The identifier for the AutoStateObject_S11 Variable.
        /// </summary>
        public const uint AutoStateObject_S11 = 15054;

        /// <summary>
        /// The identifier for the CameraObject_CameraTag Variable.
        /// </summary>
        public const uint CameraObject_CameraTag = 15056;

        /// <summary>
        /// The identifier for the CameraObject_CameraData Variable.
        /// </summary>
        public const uint CameraObject_CameraData = 15057;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Output Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Output = 15078;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Ampere Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Ampere = 15079;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_AmpereStatus Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_AmpereStatus = 15080;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Volt Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Volt = 15081;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_VoltStatus Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_VoltStatus = 15082;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Frequency Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Frequency = 15083;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Power Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Power = 15084;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerStatus Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerStatus = 15085;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerFactor Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerFactor = 15086;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Status Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Status = 15087;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Output Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Output = 15090;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Ampere Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Ampere = 15091;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_AmpereStatus Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_AmpereStatus = 15092;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Volt Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Volt = 15093;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_VoltStatus Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_VoltStatus = 15094;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Frequency Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Frequency = 15095;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Power Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Power = 15096;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerStatus Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerStatus = 15097;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerFactor Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerFactor = 15098;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Status Variable.
        /// </summary>
        public const uint Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Status = 15099;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_StartButton_Value Variable.
        /// </summary>
        public const uint Plant1_System1_OperationButton_StartButton_Value = 15102;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_StopButton_Value Variable.
        /// </summary>
        public const uint Plant1_System1_OperationButton_StopButton_Value = 15104;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_ResetButton_Value Variable.
        /// </summary>
        public const uint Plant1_System1_OperationButton_ResetButton_Value = 15106;

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_ModeButton_Value Variable.
        /// </summary>
        public const uint Plant1_System1_OperationButton_ModeButton_Value = 15108;

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController_SetPoint Variable.
        /// </summary>
        public const uint Plant1_System1_SpeedController_SetPoint = 15110;

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController_Kp Variable.
        /// </summary>
        public const uint Plant1_System1_SpeedController_Kp = 15111;

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController_Ki Variable.
        /// </summary>
        public const uint Plant1_System1_SpeedController_Ki = 15112;

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController_Kd Variable.
        /// </summary>
        public const uint Plant1_System1_SpeedController_Kd = 15113;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton2_StartButton2_Value Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_OperationButton2_StartButton2_Value = 15117;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton2_StopButton2_Value Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_OperationButton2_StopButton2_Value = 15119;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton2_ResetButton2_Value Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_OperationButton2_ResetButton2_Value = 15121;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton2_AutoButton2_Value Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_OperationButton2_AutoButton2_Value = 15123;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton2_ManualButton2_Value Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_OperationButton2_ManualButton2_Value = 15125;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_Pusher2_PushFront2_Value Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_ManualController_Pusher2_PushFront2_Value = 15129;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_Pusher2_PushBack2_Value Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_ManualController_Pusher2_PushBack2_Value = 15131;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_Belt2_Value Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_ManualController_Belt2_Value = 15133;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2_ZDown2_Value Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_ManualController_PickAndPlace2_ZDown2_Value = 15136;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2_ZUp2_Value Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_ManualController_PickAndPlace2_ZUp2_Value = 15138;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2_XRight2_Value Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_ManualController_PickAndPlace2_XRight2_Value = 15140;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2_XLeft2_Value Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_ManualController_PickAndPlace2_XLeft2_Value = 15142;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2_Pick2_Value Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_ManualController_PickAndPlace2_Pick2_Value = 15144;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2_Release2_Value Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_ManualController_PickAndPlace2_Release2_Value = 15146;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PusherM_PushFront Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM_PusherM_PushFront = 15150;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PusherM_PushBack Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM_PusherM_PushBack = 15151;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_BeltM_Belt Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM_BeltM_Belt = 15153;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_ZDown Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_ZDown = 15155;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_ZUp Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_ZUp = 15156;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_XRight Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_XRight = 15157;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_XLeft Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_XLeft = 15158;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_Pick Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_Pick = 15159;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_Release Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_Release = 15160;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorM_SSBeltBegin Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_SensorM_SSBeltBegin = 15162;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorM_SSBeltEnd Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_SensorM_SSBeltEnd = 15163;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorM_SSZUp Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_SensorM_SSZUp = 15164;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorM_SSZDown Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_SensorM_SSZDown = 15165;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorM_SSX0 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_SensorM_SSX0 = 15166;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorM_SSX1 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_SensorM_SSX1 = 15167;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorM_SSX2 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_SensorM_SSX2 = 15168;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorM_SSX3 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_SensorM_SSX3 = 15169;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters_S0 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_StateParameters_S0 = 15171;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters_S1 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_StateParameters_S1 = 15172;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters_S2 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_StateParameters_S2 = 15173;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters_S3 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_StateParameters_S3 = 15174;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters_S4 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_StateParameters_S4 = 15175;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters_S5 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_StateParameters_S5 = 15176;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters_S6 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_StateParameters_S6 = 15177;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters_S7 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_StateParameters_S7 = 15178;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters_S8 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_StateParameters_S8 = 15179;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters_S9 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_StateParameters_S9 = 15180;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters_S10 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_StateParameters_S10 = 15181;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters_S11 Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_StateParameters_S11 = 15182;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_CameraM_CameraTag Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_CameraM_CameraTag = 15184;

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_CameraM_CameraData Variable.
        /// </summary>
        public const uint PLC1214DCDCDC_Monitor_CameraM_CameraData = 15185;
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
        /// The identifier for the Plant1 Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1 = new ExpandedNodeId(ThesisServer.Objects.Plant1, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1 Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1 = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationDevice, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200 Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200 = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationDevice_PM1200, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100 Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100 = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationDevice_PM2100, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationButton = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationButton, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_StartButton Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationButton_StartButton = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationButton_StartButton, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_StopButton Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationButton_StopButton = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationButton_StopButton, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_ResetButton Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationButton_ResetButton = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationButton_ResetButton, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_ModeButton Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationButton_ModeButton = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_OperationButton_ModeButton, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_SpeedController = new ExpandedNodeId(ThesisServer.Objects.Plant1_System1_SpeedController, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton2 Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_OperationButton2 = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_OperationButton2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton2_StartButton2 Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_OperationButton2_StartButton2 = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_OperationButton2_StartButton2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton2_StopButton2 Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_OperationButton2_StopButton2 = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_OperationButton2_StopButton2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton2_ResetButton2 Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_OperationButton2_ResetButton2 = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_OperationButton2_ResetButton2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton2_AutoButton2 Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_OperationButton2_AutoButton2 = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_OperationButton2_AutoButton2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton2_ManualButton2 Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_OperationButton2_ManualButton2 = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_OperationButton2_ManualButton2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_ManualController = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_ManualController, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_Pusher2 Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_ManualController_Pusher2 = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_ManualController_Pusher2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_Pusher2_PushFront2 Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_ManualController_Pusher2_PushFront2 = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_ManualController_Pusher2_PushFront2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_Pusher2_PushBack2 Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_ManualController_Pusher2_PushBack2 = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_ManualController_Pusher2_PushBack2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_Belt2 Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_ManualController_Belt2 = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_ManualController_Belt2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2 Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_ManualController_PickAndPlace2 = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_ManualController_PickAndPlace2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2_ZDown2 Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_ManualController_PickAndPlace2_ZDown2 = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_ManualController_PickAndPlace2_ZDown2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2_ZUp2 Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_ManualController_PickAndPlace2_ZUp2 = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_ManualController_PickAndPlace2_ZUp2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2_XRight2 Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_ManualController_PickAndPlace2_XRight2 = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_ManualController_PickAndPlace2_XRight2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2_XLeft2 Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_ManualController_PickAndPlace2_XLeft2 = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_ManualController_PickAndPlace2_XLeft2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2_Pick2 Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_ManualController_PickAndPlace2_Pick2 = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_ManualController_PickAndPlace2_Pick2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2_Release2 Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_ManualController_PickAndPlace2_Release2 = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_ManualController_PickAndPlace2_Release2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_Monitor, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_Monitor_ActuatorM, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PusherM Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM_PusherM = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_Monitor_ActuatorM_PusherM, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_BeltM Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM_BeltM = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_Monitor_ActuatorM_BeltM, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorM Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_SensorM = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_Monitor_SensorM, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_StateParameters = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_Monitor_StateParameters, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_CameraM Object.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_CameraM = new ExpandedNodeId(ThesisServer.Objects.PLC1214DCDCDC_Monitor_CameraM, ThesisServer.Namespaces.ThesisServer);
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
        /// The identifier for the AutoStateObject ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateObject = new ExpandedNodeId(ThesisServer.ObjectTypes.AutoStateObject, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the CameraObject ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CameraObject = new ExpandedNodeId(ThesisServer.ObjectTypes.CameraObject, ThesisServer.Namespaces.ThesisServer);

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
        /// The identifier for the AutoStateObject_S0 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateObject_S0 = new ExpandedNodeId(ThesisServer.Variables.AutoStateObject_S0, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateObject_S1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateObject_S1 = new ExpandedNodeId(ThesisServer.Variables.AutoStateObject_S1, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateObject_S2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateObject_S2 = new ExpandedNodeId(ThesisServer.Variables.AutoStateObject_S2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateObject_S3 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateObject_S3 = new ExpandedNodeId(ThesisServer.Variables.AutoStateObject_S3, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateObject_S4 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateObject_S4 = new ExpandedNodeId(ThesisServer.Variables.AutoStateObject_S4, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateObject_S5 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateObject_S5 = new ExpandedNodeId(ThesisServer.Variables.AutoStateObject_S5, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateObject_S6 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateObject_S6 = new ExpandedNodeId(ThesisServer.Variables.AutoStateObject_S6, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateObject_S7 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateObject_S7 = new ExpandedNodeId(ThesisServer.Variables.AutoStateObject_S7, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateObject_S8 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateObject_S8 = new ExpandedNodeId(ThesisServer.Variables.AutoStateObject_S8, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateObject_S9 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateObject_S9 = new ExpandedNodeId(ThesisServer.Variables.AutoStateObject_S9, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateObject_S10 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateObject_S10 = new ExpandedNodeId(ThesisServer.Variables.AutoStateObject_S10, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AutoStateObject_S11 Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoStateObject_S11 = new ExpandedNodeId(ThesisServer.Variables.AutoStateObject_S11, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the CameraObject_CameraTag Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraObject_CameraTag = new ExpandedNodeId(ThesisServer.Variables.CameraObject_CameraTag, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the CameraObject_CameraData Variable.
        /// </summary>
        public static readonly ExpandedNodeId CameraObject_CameraData = new ExpandedNodeId(ThesisServer.Variables.CameraObject_CameraData, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Output = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Output, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Ampere Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Ampere = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Ampere, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_AmpereStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_AmpereStatus = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_AmpereStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Volt Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Volt = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Volt, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_VoltStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_VoltStatus = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_VoltStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Frequency Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Frequency = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Frequency, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Power Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Power = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Power, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerStatus = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerFactor Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerFactor = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_PowerFactor, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Status = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM1200_Pm1200Parameters_Status, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Output = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Output, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Ampere Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Ampere = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Ampere, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_AmpereStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_AmpereStatus = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_AmpereStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Volt Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Volt = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Volt, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_VoltStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_VoltStatus = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_VoltStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Frequency Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Frequency = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Frequency, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Power Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Power = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Power, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerStatus = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerStatus, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerFactor Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerFactor = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_PowerFactor, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Status = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationDevice_PM2100_Pm2100Parameters_Status, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_StartButton_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationButton_StartButton_Value = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationButton_StartButton_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_StopButton_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationButton_StopButton_Value = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationButton_StopButton_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_ResetButton_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationButton_ResetButton_Value = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationButton_ResetButton_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_OperationButton_ModeButton_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_OperationButton_ModeButton_Value = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_OperationButton_ModeButton_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController_SetPoint Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_SpeedController_SetPoint = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_SpeedController_SetPoint, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController_Kp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_SpeedController_Kp = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_SpeedController_Kp, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController_Ki Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_SpeedController_Ki = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_SpeedController_Ki, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_System1_SpeedController_Kd Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_System1_SpeedController_Kd = new ExpandedNodeId(ThesisServer.Variables.Plant1_System1_SpeedController_Kd, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton2_StartButton2_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_OperationButton2_StartButton2_Value = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_OperationButton2_StartButton2_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton2_StopButton2_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_OperationButton2_StopButton2_Value = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_OperationButton2_StopButton2_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton2_ResetButton2_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_OperationButton2_ResetButton2_Value = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_OperationButton2_ResetButton2_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton2_AutoButton2_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_OperationButton2_AutoButton2_Value = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_OperationButton2_AutoButton2_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_OperationButton2_ManualButton2_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_OperationButton2_ManualButton2_Value = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_OperationButton2_ManualButton2_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_Pusher2_PushFront2_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_ManualController_Pusher2_PushFront2_Value = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_ManualController_Pusher2_PushFront2_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_Pusher2_PushBack2_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_ManualController_Pusher2_PushBack2_Value = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_ManualController_Pusher2_PushBack2_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_Belt2_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_ManualController_Belt2_Value = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_ManualController_Belt2_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2_ZDown2_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_ManualController_PickAndPlace2_ZDown2_Value = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_ManualController_PickAndPlace2_ZDown2_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2_ZUp2_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_ManualController_PickAndPlace2_ZUp2_Value = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_ManualController_PickAndPlace2_ZUp2_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2_XRight2_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_ManualController_PickAndPlace2_XRight2_Value = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_ManualController_PickAndPlace2_XRight2_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2_XLeft2_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_ManualController_PickAndPlace2_XLeft2_Value = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_ManualController_PickAndPlace2_XLeft2_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2_Pick2_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_ManualController_PickAndPlace2_Pick2_Value = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_ManualController_PickAndPlace2_Pick2_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_ManualController_PickAndPlace2_Release2_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_ManualController_PickAndPlace2_Release2_Value = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_ManualController_PickAndPlace2_Release2_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PusherM_PushFront Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM_PusherM_PushFront = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_ActuatorM_PusherM_PushFront, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PusherM_PushBack Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM_PusherM_PushBack = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_ActuatorM_PusherM_PushBack, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_BeltM_Belt Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM_BeltM_Belt = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_ActuatorM_BeltM_Belt, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_ZDown Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_ZDown = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_ZDown, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_ZUp Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_ZUp = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_ZUp, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_XRight Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_XRight = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_XRight, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_XLeft Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_XLeft = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_XLeft, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_Pick Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_Pick = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_Pick, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_Release Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_Release = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_ActuatorM_PickAndPlaceM_Release, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorM_SSBeltBegin Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_SensorM_SSBeltBegin = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_SensorM_SSBeltBegin, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorM_SSBeltEnd Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_SensorM_SSBeltEnd = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_SensorM_SSBeltEnd, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorM_SSZUp Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_SensorM_SSZUp = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_SensorM_SSZUp, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorM_SSZDown Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_SensorM_SSZDown = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_SensorM_SSZDown, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorM_SSX0 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_SensorM_SSX0 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_SensorM_SSX0, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorM_SSX1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_SensorM_SSX1 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_SensorM_SSX1, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorM_SSX2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_SensorM_SSX2 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_SensorM_SSX2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_SensorM_SSX3 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_SensorM_SSX3 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_SensorM_SSX3, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters_S0 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_StateParameters_S0 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_StateParameters_S0, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters_S1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_StateParameters_S1 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_StateParameters_S1, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters_S2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_StateParameters_S2 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_StateParameters_S2, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters_S3 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_StateParameters_S3 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_StateParameters_S3, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters_S4 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_StateParameters_S4 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_StateParameters_S4, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters_S5 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_StateParameters_S5 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_StateParameters_S5, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters_S6 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_StateParameters_S6 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_StateParameters_S6, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters_S7 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_StateParameters_S7 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_StateParameters_S7, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters_S8 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_StateParameters_S8 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_StateParameters_S8, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters_S9 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_StateParameters_S9 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_StateParameters_S9, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters_S10 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_StateParameters_S10 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_StateParameters_S10, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_StateParameters_S11 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_StateParameters_S11 = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_StateParameters_S11, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_CameraM_CameraTag Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_CameraM_CameraTag = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_CameraM_CameraTag, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the PLC1214DCDCDC_Monitor_CameraM_CameraData Variable.
        /// </summary>
        public static readonly ExpandedNodeId PLC1214DCDCDC_Monitor_CameraM_CameraData = new ExpandedNodeId(ThesisServer.Variables.PLC1214DCDCDC_Monitor_CameraM_CameraData, ThesisServer.Namespaces.ThesisServer);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
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
        /// The BrowseName for the AutoStateObject component.
        /// </summary>
        public const string AutoStateObject = "AutoStateObject";

        /// <summary>
        /// The BrowseName for the Belt component.
        /// </summary>
        public const string Belt = "Belt";

        /// <summary>
        /// The BrowseName for the ButtonType component.
        /// </summary>
        public const string ButtonType = "ButtonType";

        /// <summary>
        /// The BrowseName for the CameraData component.
        /// </summary>
        public const string CameraData = "CameraData";

        /// <summary>
        /// The BrowseName for the CameraObject component.
        /// </summary>
        public const string CameraObject = "CameraObject";

        /// <summary>
        /// The BrowseName for the CameraTag component.
        /// </summary>
        public const string CameraTag = "CameraTag";

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
        /// The BrowseName for the ManualController component.
        /// </summary>
        public const string ManualController = "Manual Controller";

        /// <summary>
        /// The BrowseName for the Monitor component.
        /// </summary>
        public const string Monitor = "Monitor";

        /// <summary>
        /// The BrowseName for the OperationButton2 component.
        /// </summary>
        public const string OperationButton2 = "Operation Button";

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
        /// The BrowseName for the Plant1 component.
        /// </summary>
        public const string Plant1 = "Plant 1";

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
        /// The BrowseName for the System1 component.
        /// </summary>
        public const string System1 = "Tank 1";

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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
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
}