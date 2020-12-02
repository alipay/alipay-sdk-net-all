using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppStressHeartbeatUploadResponse.
    /// </summary>
    public class AlipayEbppStressHeartbeatUploadResponse : AopResponse
    {
        /// <summary>
        /// 下一个状态的状态码
        /// </summary>
        [XmlElement("next_status")]
        public string NextStatus { get; set; }

        /// <summary>
        /// 上报是否成功标识
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
