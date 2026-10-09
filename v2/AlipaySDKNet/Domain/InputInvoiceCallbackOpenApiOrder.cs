using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InputInvoiceCallbackOpenApiOrder Data Structure.
    /// </summary>
    [Serializable]
    public class InputInvoiceCallbackOpenApiOrder : AopObject
    {
        /// <summary>
        /// 失败原因
        /// </summary>
        [XmlElement("error_info")]
        public string ErrorInfo { get; set; }

        /// <summary>
        /// 发票id
        /// </summary>
        [XmlElement("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 确认的topic的mqKey
        /// </summary>
        [XmlElement("mq_key")]
        public string MqKey { get; set; }

        /// <summary>
        /// 通知是否成功
        /// </summary>
        [XmlElement("notify_succeeded")]
        public bool NotifySucceeded { get; set; }
    }
}
