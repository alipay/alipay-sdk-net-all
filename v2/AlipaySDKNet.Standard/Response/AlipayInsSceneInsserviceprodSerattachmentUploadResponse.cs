using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodSerattachmentUploadResponse.
    /// </summary>
    public class AlipayInsSceneInsserviceprodSerattachmentUploadResponse : AopResponse
    {
        /// <summary>
        /// 附件编号(业务主键)
        /// </summary>
        [XmlElement("attachment_no")]
        public string AttachmentNo { get; set; }
    }
}
