using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserWufufukaAliyunFinishResponse.
    /// </summary>
    public class AlipayUserWufufukaAliyunFinishResponse : AopResponse
    {
        /// <summary>
        /// 是否需要重试，接口失败情况下，根据该字段判断是否需要重试
        /// </summary>
        [XmlElement("retry_flag")]
        public bool RetryFlag { get; set; }
    }
}
