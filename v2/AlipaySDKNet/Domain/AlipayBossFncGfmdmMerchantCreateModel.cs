using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfmdmMerchantCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfmdmMerchantCreateModel : AopObject
    {
        /// <summary>
        /// B类客商填写统一信用编码，C类客商填写个人身份证
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 2位代码，请联系主数据onwer咨询。超过200多个枚举值，没法提前录入
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 客商主数据商户唯一ID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商户状态信息，Y->有效；N->无效
        /// </summary>
        [XmlElement("merchant_status")]
        public string MerchantStatus { get; set; }

        /// <summary>
        /// 标识商户类型，B->企业类客商；C->个人类客商
        /// </summary>
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 省份区域信息
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 来源系统的APP code，每个系统由自己特有的code，没法预先设置枚举值，请接入时跟主数据owner沟通
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 来源系统ID，即上游客商库自定义的唯一主键信息
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 当前客商在来源系统中的状态
        /// </summary>
        [XmlElement("source_status")]
        public string SourceStatus { get; set; }

        /// <summary>
        /// 国外商户税号，一般情况下不填写，直接填写在cert_no证件号即可
        /// </summary>
        [XmlElement("tax_id")]
        public string TaxId { get; set; }
    }
}
