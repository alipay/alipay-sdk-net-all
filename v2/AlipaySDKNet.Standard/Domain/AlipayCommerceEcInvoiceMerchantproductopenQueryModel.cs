using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcInvoiceMerchantproductopenQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcInvoiceMerchantproductopenQueryModel : AopObject
    {
        /// <summary>
        /// 产品开通流水ID
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 外部产品开通申请ID
        /// </summary>
        [XmlElement("out_apply_id")]
        public string OutApplyId { get; set; }

        /// <summary>
        /// 企业（商户）税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
