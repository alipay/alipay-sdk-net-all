using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentPlanDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentPlanDTO : AopObject
    {
        /// <summary>
        /// 是否按比例支付
        /// </summary>
        [XmlElement("pay_on_percent")]
        public string PayOnPercent { get; set; }

        /// <summary>
        /// 条款名称
        /// </summary>
        [XmlElement("payment_name")]
        public string PaymentName { get; set; }

        /// <summary>
        /// 付款计划行信息
        /// </summary>
        [XmlArray("payment_plan_item_list")]
        [XmlArrayItem("payment_plan_item_d_t_o")]
        public List<PaymentPlanItemDTO> PaymentPlanItemList { get; set; }

        /// <summary>
        /// 条款类型
        /// </summary>
        [XmlElement("payment_type")]
        public string PaymentType { get; set; }

        /// <summary>
        /// 采购订单id
        /// </summary>
        [XmlElement("purchase_order_id")]
        public string PurchaseOrderId { get; set; }
    }
}
