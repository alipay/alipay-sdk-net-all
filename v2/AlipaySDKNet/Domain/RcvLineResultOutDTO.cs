using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RcvLineResultOutDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RcvLineResultOutDTO : AopObject
    {
        /// <summary>
        /// 费用归属月份
        /// </summary>
        [XmlElement("expense_month")]
        public string ExpenseMonth { get; set; }

        /// <summary>
        /// 物品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// QUANTITY/AMOUNT(按金额/按数量)
        /// </summary>
        [XmlElement("line_type")]
        public string LineType { get; set; }

        /// <summary>
        /// po行号
        /// </summary>
        [XmlElement("po_line_num")]
        public long PoLineNum { get; set; }

        /// <summary>
        /// 可执行金额或数量
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 接受日期
        /// </summary>
        [XmlElement("rcv_date")]
        public string RcvDate { get; set; }

        /// <summary>
        /// 接收单行ID
        /// </summary>
        [XmlElement("rcv_line_id")]
        public string RcvLineId { get; set; }

        /// <summary>
        /// 接收单行号
        /// </summary>
        [XmlElement("rcv_line_num")]
        public long RcvLineNum { get; set; }

        /// <summary>
        /// 已接收金额/元
        /// </summary>
        [XmlElement("received_amount")]
        public string ReceivedAmount { get; set; }

        /// <summary>
        /// 已接收金额或数量
        /// </summary>
        [XmlElement("received_quantity")]
        public string ReceivedQuantity { get; set; }
    }
}
