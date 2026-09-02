using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcChannelinvoiceMerchantopenGetResponse.
    /// </summary>
    public class AlipayCommerceEcChannelinvoiceMerchantopenGetResponse : AopResponse
    {
        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 企业税号
        /// </summary>
        [XmlElement("company_tax_no")]
        public string CompanyTaxNo { get; set; }

        /// <summary>
        /// 开通失败原因
        /// </summary>
        [XmlElement("open_fail_reason")]
        public string OpenFailReason { get; set; }

        /// <summary>
        /// 开通状态
        /// </summary>
        [XmlElement("open_status")]
        public string OpenStatus { get; set; }

        /// <summary>
        /// 外部渠道商户 ID
        /// </summary>
        [XmlElement("out_channel_merchant_id")]
        public string OutChannelMerchantId { get; set; }

        /// <summary>
        /// 外部渠道商户名称
        /// </summary>
        [XmlElement("out_channel_merchant_name")]
        public string OutChannelMerchantName { get; set; }
    }
}
