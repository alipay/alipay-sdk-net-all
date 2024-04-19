using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMultimediaResourceMasstokenGetResponse.
    /// </summary>
    public class AlipayMultimediaResourceMasstokenGetResponse : AopResponse
    {
        /// <summary>
        /// token创建时间戳，秒
        /// </summary>
        [XmlElement("create_time")]
        public long CreateTime { get; set; }

        /// <summary>
        /// token失效时间戳，秒
        /// </summary>
        [XmlElement("dead_time")]
        public long DeadTime { get; set; }

        /// <summary>
        /// 从AFTS系统获取的token参数，用于从AFTS系统上传下载操作时的鉴权参数。示例值仅供参考，无法直接使用。
        /// </summary>
        [XmlElement("mass_token")]
        public string MassToken { get; set; }
    }
}
