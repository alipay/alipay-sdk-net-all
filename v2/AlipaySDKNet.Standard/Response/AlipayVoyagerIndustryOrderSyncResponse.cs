using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayVoyagerIndustryOrderSyncResponse.
    /// </summary>
    public class AlipayVoyagerIndustryOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 消费状态
        /// </summary>
        [XmlElement("consume_status")]
        public string ConsumeStatus { get; set; }

        /// <summary>
        /// 成功时为空，失败时返回平台错误码名称
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// true: 调用方应重试; false: 调用方不应重试
        /// </summary>
        [XmlElement("need_retry")]
        public bool NeedRetry { get; set; }
    }
}
