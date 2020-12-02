using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VehicleConditionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VehicleConditionInfo : AopObject
    {
        /// <summary>
        /// 车况类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 车况信息单位
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// 车况属性值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
