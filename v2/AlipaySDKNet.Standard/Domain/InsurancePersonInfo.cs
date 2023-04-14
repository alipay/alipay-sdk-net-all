using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsurancePersonInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InsurancePersonInfo : AopObject
    {
        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("card_code")]
        public string CardCode { get; set; }

        /// <summary>
        /// 投保人证件类型 01-居民身份证 03-营业执照
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        [XmlElement("contact_info")]
        public string ContactInfo { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
