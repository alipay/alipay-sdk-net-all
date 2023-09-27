using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InputInvoiceMqDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InputInvoiceMqDTO : AopObject
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
        /// 发票id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 发票模型,如果process_result为PRE_CHECK时,会将发票验真后的数据填充到此模型中
        /// </summary>
        [XmlElement("input_invoice_dto")]
        public InputInvoiceCheckResponse InputInvoiceDto { get; set; }

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
        /// mqKey,用于消息幂等
        /// </summary>
        [XmlElement("mq_key")]
        public string MqKey { get; set; }

        /// <summary>
        /// 目前只有当processType是验真和勾选时，发送消息才会携带processResult结果信息
        /// </summary>
        [XmlElement("process_result")]
        public bool ProcessResult { get; set; }

        /// <summary>
        /// 回调消息类型
        /// </summary>
        [XmlElement("process_type")]
        public string ProcessType { get; set; }

        /// <summary>
        /// 业务关联单号
        /// </summary>
        [XmlElement("related_order")]
        public string RelatedOrder { get; set; }

        /// <summary>
        /// 从发起验真接口获取taskId
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
