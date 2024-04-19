using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodSerattachmentDeleteResponse.
    /// </summary>
    public class AlipayInsSceneInsserviceprodSerattachmentDeleteResponse : AopResponse
    {
        /// <summary>
        /// 文件编号 (原封不动地把请求中的附件编号返回给你)
        /// </summary>
        [XmlElement("attachment_no")]
        public string AttachmentNo { get; set; }
    }
}
