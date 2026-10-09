using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceArrivalDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceArrivalDetailDTO : AopObject
    {
        /// <summary>
        /// 到票关系ID
        /// </summary>
        [XmlElement("arrival_id")]
        public long ArrivalId { get; set; }

        /// <summary>
        /// 费用ID
        /// </summary>
        [XmlElement("expense_id")]
        public string ExpenseId { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_json")]
        public string ExtJson { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 到票明细主键
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 发票账单ID
        /// </summary>
        [XmlElement("invoice_bill_id")]
        public long InvoiceBillId { get; set; }

        /// <summary>
        /// 发票ID
        /// </summary>
        [XmlElement("invoice_id")]
        public long InvoiceId { get; set; }

        /// <summary>
        /// 发票行ID
        /// </summary>
        [XmlElement("invoice_line_id")]
        public long InvoiceLineId { get; set; }

        /// <summary>
        /// 到票金额（单位：各币种的“元”单位，精确到小数点后2位）
        /// </summary>
        [XmlElement("use_amount")]
        public string UseAmount { get; set; }

        /// <summary>
        /// 代扣税金额（单位：各币种的“元”单位，精确到小数点后2位）
        /// </summary>
        [XmlElement("wht_amount")]
        public string WhtAmount { get; set; }

        /// <summary>
        /// 代扣税税率
        /// </summary>
        [XmlElement("wht_rate")]
        public string WhtRate { get; set; }
    }
}
