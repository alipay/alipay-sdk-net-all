using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceFileOutputQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceFileOutputQueryModel : AopObject
    {
        /// <summary>
        /// 发票代码  字段长度（10-12位）
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票号码  字段长度（8-10位）
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票pdf文件下载应用场景。固定为 INVOICE_EXPENSE  表示发票报销。
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 是否跳过发票报销状态同步；当为true时，跳过报销状态同步校验。默认为false，需要先做报销状态同步
        /// </summary>
        [XmlElement("skip_expense_progress_sync")]
        public bool SkipExpenseProgressSync { get; set; }

        /// <summary>
        /// 发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
