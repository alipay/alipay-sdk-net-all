using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ObcInvoiceObjectRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ObcInvoiceObjectRequest : AopObject
    {
        /// <summary>
        /// 账单号/订单号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 包年包月订单/按量付费账单
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 开票金额，不传则默认全额开票；和申请单币种保持一致，目前非国际发票支持CNY，金额单位为元
        /// </summary>
        [XmlElement("invoicing_amount")]
        public string InvoicingAmount { get; set; }
    }
}
