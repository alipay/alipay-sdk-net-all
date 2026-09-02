using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LucContactWayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LucContactWayInfo : AopObject
    {
        /// <summary>
        /// 联系方式类型: MOBILE-手机号码 / PHONE-固定电话
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 联系方式值（电话号码）
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
