using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcInvoiceresultConsumeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcInvoiceresultConsumeQueryModel : AopObject
    {
        /// <summary>
        /// 企业id，可通过查询入驻企业码企业详情获取
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 开票申请id，发起开票申请后返回的申请id
        /// </summary>
        [XmlElement("invoice_apply_id")]
        public string InvoiceApplyId { get; set; }

        /// <summary>
        /// 外部开票申请id，调用方自定义生成，且保证唯一
        /// </summary>
        [XmlElement("outer_apply_id")]
        public string OuterApplyId { get; set; }
    }
}
