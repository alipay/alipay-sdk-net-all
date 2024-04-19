using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceDmpserviceCreateResponse.
    /// </summary>
    public class AlipayDataDataserviceDmpserviceCreateResponse : AopResponse
    {
        /// <summary>
        /// 服务端的处理时间
        /// </summary>
        [XmlElement("event_time")]
        public string EventTime { get; set; }

        /// <summary>
        /// 0: 提交成功 1: 提交失败
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
