using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceHousingFileUploadResponse.
    /// </summary>
    public class AlipayCommerceHousingFileUploadResponse : AopResponse
    {
        /// <summary>
        /// 附件id
        /// </summary>
        [XmlElement("attachment_id")]
        public string AttachmentId { get; set; }
    }
}
