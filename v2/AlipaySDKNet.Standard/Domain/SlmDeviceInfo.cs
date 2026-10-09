using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SlmDeviceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SlmDeviceInfo : AopObject
    {
        /// <summary>
        /// 设备品牌
        /// </summary>
        [XmlElement("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 设备平台
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// 产品名
        /// </summary>
        [XmlElement("product")]
        public string Product { get; set; }

        /// <summary>
        /// 设备归属
        /// </summary>
        [XmlElement("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// 设备唯一标识
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 业务分类
        /// </summary>
        [XmlElement("support")]
        public string Support { get; set; }
    }
}
