using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceTaskInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceTaskInfo : AopObject
    {
        /// <summary>
        /// 回票完成时间
        /// </summary>
        [XmlElement("finish_date")]
        public string FinishDate { get; set; }

        /// <summary>
        /// 已回票金额，单位为元
        /// </summary>
        [XmlElement("finish_invoice_amount")]
        public string FinishInvoiceAmount { get; set; }

        /// <summary>
        /// 应回票金额，单位为元
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 回票主体名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 任务周期起始时间
        /// </summary>
        [XmlElement("period_begin_date")]
        public string PeriodBeginDate { get; set; }

        /// <summary>
        /// 任务周期结束时间
        /// </summary>
        [XmlElement("period_end_date")]
        public string PeriodEndDate { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务状态 待提交回票:WAIT_INVOICE 发票处理中:INVOICE_PROCESSING 发票已验证完成：INVOICE_VERIFIED 已回票：INVOICED
        /// </summary>
        [XmlElement("task_status")]
        public string TaskStatus { get; set; }

        /// <summary>
        /// 当前任务的正向支付金额（单位为元）
        /// </summary>
        [XmlElement("total_pay_amount")]
        public string TotalPayAmount { get; set; }

        /// <summary>
        /// 当前回票任务中总退款的金额（单位为元）
        /// </summary>
        [XmlElement("total_refund_amount")]
        public string TotalRefundAmount { get; set; }
    }
}
