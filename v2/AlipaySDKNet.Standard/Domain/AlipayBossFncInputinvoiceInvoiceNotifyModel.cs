using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncInputinvoiceInvoiceNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInputinvoiceInvoiceNotifyModel : AopObject
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 发票id,唯一
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 集团的mqKey,蚂蚁侧用做幂等键
        /// </summary>
        [XmlElement("mq_key")]
        public string MqKey { get; set; }

        /// <summary>
        /// 业务处理结果，只有当processType是验真和勾选时，才会携带processResult结果信息
        /// </summary>
        [XmlElement("process_result")]
        public bool ProcessResult { get; set; }

        /// <summary>
        /// 业务处理类型，RETURN_COMPLETE、CERTIFY、DISTRIBUTED_WITHDRAW、DISTRIBUTE、CHECK
        /// </summary>
        [XmlElement("process_type")]
        public string ProcessType { get; set; }

        /// <summary>
        /// 业务关联单号
        /// </summary>
        [XmlElement("related_order")]
        public string RelatedOrder { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
