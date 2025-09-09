using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CaSdnDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CaSdnDTO : AopObject
    {
        /// <summary>
        /// 所在国家 (Country) 简称：C 字段，只能是国家字母缩写，如中国：CN。由于简称方式不定，不可枚举
        /// </summary>
        [XmlElement("c")]
        public string C { get; set; }

        /// <summary>
        /// 公用名称 (Common Name) 简称：CN 字段，对于 SSL 证书，一般为网站域名；而对于代码签名证书则为申请单位名称；而对于客户端证书则为证书申请者的姓名
        /// </summary>
        [XmlElement("cn")]
        public string Cn { get; set; }

        /// <summary>
        /// 单位名称 (Organization Name) ：简称：O 字段，对于 SSL 证书，一般为网站域名；而对于代码签名证书则为申请单位名称；而对于客户端单位证书则为证书申请者所在单位名称；
        /// </summary>
        [XmlElement("o")]
        public string O { get; set; }

        /// <summary>
        /// 显示其他内容 简称：OU 字段
        /// </summary>
        [XmlElement("ou")]
        public string Ou { get; set; }

        /// <summary>
        /// 电话号码：Phone 字段，格式要求 + 国家区号 城市区号 电话号码，如： +86 732 88888888
        /// </summary>
        [XmlElement("telephone_number")]
        public string TelephoneNumber { get; set; }
    }
}
