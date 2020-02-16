using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncApinvoiceBatchAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncApinvoiceBatchAddModel : AopObject
    {
        /// <summary>
        /// 应付对账单发票关联明细
        /// </summary>
        [XmlArray("ap_invoice_bill_link_orders")]
        [XmlArrayItem("ap_invoice_bill_link_order_request")]
        public List<ApInvoiceBillLinkOrderRequest> ApInvoiceBillLinkOrders { get; set; }

        /// <summary>
        /// 应付发票
        /// </summary>
        [XmlArray("ap_invoice_order_list")]
        [XmlArrayItem("ap_invoice_order_request")]
        public List<ApInvoiceOrderRequest> ApInvoiceOrderList { get; set; }

        /// <summary>
        /// 发票备注信息memo
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 当前操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 当前操作人类型，01:ISV 02:管理员(小二)
        /// </summary>
        [XmlElement("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 个人无票税损比例，有效范围[0,1]
        /// </summary>
        [XmlElement("personal_tax_loss_rate")]
        public long PersonalTaxLossRate { get; set; }
    }
}
