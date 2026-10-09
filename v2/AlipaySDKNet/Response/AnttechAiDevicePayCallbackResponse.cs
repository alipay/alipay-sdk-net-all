using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechAiDevicePayCallbackResponse.
    /// </summary>
    public class AnttechAiDevicePayCallbackResponse : AopResponse
    {
        /// <summary>
        /// 业务回执，调用方需要 说明： 如果在提交创建任务的请求参数中传入了biz_receiet，则此处返回对应的biz_receiet
        /// </summary>
        [XmlElement("biz_receiet")]
        public string BizReceiet { get; set; }

        /// <summary>
        /// 调用设备支付回执对应的请求ID 说明： 如果在提交创建任务的请求参数中传入了request_id，则此处返回对应的request_id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
