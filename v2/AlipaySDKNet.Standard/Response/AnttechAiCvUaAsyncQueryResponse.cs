using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechAiCvUaAsyncQueryResponse.
    /// </summary>
    public class AnttechAiCvUaAsyncQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果访问机器域名
        /// </summary>
        [XmlElement("host")]
        public string Host { get; set; }

        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 预测结果详情
        /// </summary>
        [XmlElement("result_detail")]
        public string ResultDetail { get; set; }

        /// <summary>
        /// 返回结果msg
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 本次调用是否成功
        /// </summary>
        [XmlElement("result_success")]
        public string ResultSuccess { get; set; }

        /// <summary>
        /// 返回结果url
        /// </summary>
        [XmlElement("result_url")]
        public string ResultUrl { get; set; }

        /// <summary>
        /// running succ fail timeout
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
