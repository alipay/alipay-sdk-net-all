using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VehicleModuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VehicleModuleInfo : AopObject
    {
        /// <summary>
        /// 车辆状态信息描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 车辆控制模块
        /// </summary>
        [XmlElement("function")]
        public string Function { get; set; }

        /// <summary>
        /// 车辆模块状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
