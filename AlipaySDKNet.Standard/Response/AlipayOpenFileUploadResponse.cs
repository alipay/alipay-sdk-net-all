using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenFileUploadResponse.
    /// </summary>
    public class AlipayOpenFileUploadResponse : AopResponse
    {
        /// <summary>
        /// 视频资源id，同步外部渠道后，外部渠道返回的id。目前支持同步优酷场景，返回优酷视频id，用于支付宝客户端播放视频使用
        /// </summary>
        [XmlElement("extern_id")]
        public string ExternId { get; set; }

        /// <summary>
        /// 文件id，用于提供后后续业务调用使用
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
