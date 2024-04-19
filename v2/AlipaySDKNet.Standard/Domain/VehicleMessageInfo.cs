using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VehicleMessageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VehicleMessageInfo : AopObject
    {
        /// <summary>
        /// vehicle_cond_infos 是车况信息列表,包含VehicleConditionInfo子类型(比如电频,电压,里程等信息)
        /// </summary>
        [XmlArray("vehicle_cond_infos")]
        [XmlArrayItem("vehicle_condition_info")]
        public List<VehicleConditionInfo> VehicleCondInfos { get; set; }

        /// <summary>
        /// vehicle_module_infos是车辆模组信息列表,包含VehicleModuleInfo子类型(比如引擎、车门、后备箱等信息)
        /// </summary>
        [XmlArray("vehicle_module_infos")]
        [XmlArrayItem("vehicle_module_info")]
        public List<VehicleModuleInfo> VehicleModuleInfos { get; set; }
    }
}
