using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwAttachmentCreateResponse.
    /// </summary>
    public class AlipayIserviceCcmSwAttachmentCreateResponse : AopResponse
    {
        /// <summary>
        /// 附件id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
