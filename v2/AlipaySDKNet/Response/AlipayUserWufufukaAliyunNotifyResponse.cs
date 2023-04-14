using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserWufufukaAliyunNotifyResponse.
    /// </summary>
    public class AlipayUserWufufukaAliyunNotifyResponse : AopResponse
    {
        /// <summary>
        /// 是否重试flag，下游理解并判断是否重试
        /// </summary>
        [XmlElement("retry_flag")]
        public bool RetryFlag { get; set; }
    }
}
