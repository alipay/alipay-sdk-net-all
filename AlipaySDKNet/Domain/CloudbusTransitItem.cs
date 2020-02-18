using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CloudbusTransitItem Data Structure.
    /// </summary>
    [Serializable]
    public class CloudbusTransitItem : AopObject
    {
        /// <summary>
        /// 月份
        /// </summary>
        [XmlElement("month")]
        public string Month { get; set; }

        /// <summary>
        /// 客流走廊类型，枚举  0 公共出行 1 不含地铁 2 现有线网
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// oss访问地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
