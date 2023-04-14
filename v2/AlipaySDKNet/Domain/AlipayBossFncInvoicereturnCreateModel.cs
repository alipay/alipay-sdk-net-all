using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncInvoicereturnCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInvoicereturnCreateModel : AopObject
    {
        /// <summary>
        /// 申请明细
        /// </summary>
        [XmlArray("ar_invoice_return_apply_detail_orders")]
        [XmlArrayItem("ar_invoice_return_detail_order")]
        public List<ArInvoiceReturnDetailOrder> ArInvoiceReturnApplyDetailOrders { get; set; }

        /// <summary>
        /// 申请退换票的备注消息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 修改项
        /// </summary>
        [XmlElement("modified_item")]
        public string ModifiedItem { get; set; }

        /// <summary>
        /// 当前操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 当前操作人类型,01:商户 02:管理员(小二)
        /// </summary>
        [XmlElement("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 退换票类型,01:退票 02:换票
        /// </summary>
        [XmlElement("return_order_type")]
        public string ReturnOrderType { get; set; }

        /// <summary>
        /// 退换票原因类型 01：发票介质修改 02：发票类型修改 03：发票信息修改 05：其他 06：不需要发票
        /// </summary>
        [XmlElement("return_reason_type")]
        public string ReturnReasonType { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [XmlElement("tracking_no")]
        public string TrackingNo { get; set; }
    }
}
