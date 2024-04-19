using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechAiCvUaAsyncIdentifyResponse.
    /// </summary>
    public class AnttechAiCvUaAsyncIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 调用机器域名
        /// </summary>
        [XmlElement("host")]
        public string Host { get; set; }

        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果msg
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [XmlElement("result_success")]
        public string ResultSuccess { get; set; }

        /// <summary>
        /// 模型服务code
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 用于后续查询结果使用
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
