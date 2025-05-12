using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecyclinginvoiceOrderAuditItem Data Structure.
    /// </summary>
    [Serializable]
    public class RecyclinginvoiceOrderAuditItem : AopObject
    {
        /// <summary>
        /// 数量（整数最长七位，小数最长六位）
        /// </summary>
        [XmlElement("item_num")]
        public string ItemNum { get; set; }

        /// <summary>
        /// 金额（元，整数最长七位，小数最长两位）
        /// </summary>
        [XmlElement("item_total_amount")]
        public string ItemTotalAmount { get; set; }

        /// <summary>
        /// 单价（元，整数最长七位，小数最长六位）
        /// </summary>
        [XmlElement("item_unit_amount")]
        public string ItemUnitAmount { get; set; }

        /// <summary>
        /// 订单明细ID，可通过反向订单查询接口查询
        /// </summary>
        [XmlElement("order_item_id")]
        public string OrderItemId { get; set; }
    }
}
