using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RcvLineDto Data Structure.
    /// </summary>
    [Serializable]
    public class RcvLineDto : AopObject
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
        /// po行的id
        /// </summary>
        [XmlElement("po_line_id")]
        public string PoLineId { get; set; }

        /// <summary>
        /// po行的行号
        /// </summary>
        [XmlElement("po_line_num")]
        public long PoLineNum { get; set; }

        /// <summary>
        /// 接收单id
        /// </summary>
        [XmlElement("rcv_line_id")]
        public string RcvLineId { get; set; }

        /// <summary>
        /// 接收单行号
        /// </summary>
        [XmlElement("rcv_line_num")]
        public long RcvLineNum { get; set; }

        /// <summary>
        /// 要接收的金额或数量/元
        /// </summary>
        [XmlElement("received_amount")]
        public string ReceivedAmount { get; set; }
    }
}
