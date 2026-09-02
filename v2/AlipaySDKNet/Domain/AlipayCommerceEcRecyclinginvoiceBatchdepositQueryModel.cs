using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceBatchdepositQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceBatchdepositQueryModel : AopObject
    {
        /// <summary>
        /// 批次请款单ID
        /// </summary>
        [XmlElement("batch_deposit_id")]
        public string BatchDepositId { get; set; }

        /// <summary>
        /// 企业（商户）税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
