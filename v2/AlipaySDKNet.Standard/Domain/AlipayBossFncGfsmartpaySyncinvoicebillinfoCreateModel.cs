using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsmartpaySyncinvoicebillinfoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsmartpaySyncinvoicebillinfoCreateModel : AopObject
    {
        /// <summary>
        /// 核销单DTO
        /// </summary>
        [XmlElement("invoice_bill_info_dto")]
        public BizInvoiceBillInfoDTO InvoiceBillInfoDto { get; set; }
    }
}
