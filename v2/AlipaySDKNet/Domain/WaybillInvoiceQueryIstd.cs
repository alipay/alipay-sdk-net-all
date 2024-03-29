using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WaybillInvoiceQueryIstd Data Structure.
    /// </summary>
    [Serializable]
    public class WaybillInvoiceQueryIstd : AopObject
    {
        /// <summary>
        /// 失败原因，需要传单个即时配送运单的驳回原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 商家门店编号
        /// </summary>
        [XmlElement("shop_no")]
        public string ShopNo { get; set; }

        /// <summary>
        /// 即时配送运单金额，waybill_invoce_status为1的情况下不能为空
        /// </summary>
        [XmlElement("waybill_amount")]
        public string WaybillAmount { get; set; }

        /// <summary>
        /// 明细的运单开票状态，1：开票成功 2：不可开票 3：可开票；整体开票状态为0的情况下，无开票明细；整体开票状态为1，明细开票状态全部是1；整体开票状态为2，明细开票状态全部为2
        /// </summary>
        [XmlElement("waybill_invoice_status")]
        public long WaybillInvoiceStatus { get; set; }

        /// <summary>
        /// 即时配送运单编号
        /// </summary>
        [XmlElement("waybill_no")]
        public string WaybillNo { get; set; }
    }
}
