using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InputInvoiceCallbackOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InputInvoiceCallbackOpenApiDTO : AopObject
    {
        /// <summary>
        /// 回调消息类型
        /// </summary>
        [XmlElement("callback_type")]
        public string CallbackType { get; set; }

        /// <summary>
        /// 业务接收通知消息后针对失败拒绝的详情信息
        /// </summary>
        [XmlElement("error_info_dto")]
        public ErrorInfoDTO ErrorInfoDto { get; set; }

        /// <summary>
        /// 发票id
        /// </summary>
        [XmlElement("invoice_id")]
        public long InvoiceId { get; set; }

        /// <summary>
        /// 确认的topic的mqKey，用于消息幂等
        /// </summary>
        [XmlElement("mq_key")]
        public string MqKey { get; set; }

        /// <summary>
        /// 业务接收通知消息后是否成功消费
        /// </summary>
        [XmlElement("notify_succeeded")]
        public bool NotifySucceeded { get; set; }

        /// <summary>
        /// 平台code
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 请求幂等号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }
    }
}
