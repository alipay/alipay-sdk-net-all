using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsuredInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InsuredInfo : AopObject
    {
        /// <summary>
        /// 被保人扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 被保人出生日期 yyyy-MM-dd
        /// </summary>
        [XmlElement("insured_birthday")]
        public string InsuredBirthday { get; set; }

        /// <summary>
        /// 被保人证件号
        /// </summary>
        [XmlElement("insured_cert_no")]
        public string InsuredCertNo { get; set; }

        /// <summary>
        /// 被保人证件类型
        /// </summary>
        [XmlElement("insured_cert_type")]
        public string InsuredCertType { get; set; }

        /// <summary>
        /// 被保人姓名
        /// </summary>
        [XmlElement("insured_name")]
        public string InsuredName { get; set; }

        /// <summary>
        /// 状态枚举 有效-effective 失效-ineffective
        /// </summary>
        [XmlElement("insured_status")]
        public string InsuredStatus { get; set; }
    }
}
