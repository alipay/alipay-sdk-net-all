using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserWufufukaAliyunRefundResponse.
    /// </summary>
    public class AlipayUserWufufukaAliyunRefundResponse : AopResponse
    {
        /// <summary>
        /// 是否需要重试，请求失败情况下，阿里云基于该字段判断该请求是否需要重试
        /// </summary>
        [XmlElement("retry_flag")]
        public bool RetryFlag { get; set; }
    }
}
