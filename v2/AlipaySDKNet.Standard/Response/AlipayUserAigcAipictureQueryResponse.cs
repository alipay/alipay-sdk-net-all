using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAigcAipictureQueryResponse.
    /// </summary>
    public class AlipayUserAigcAipictureQueryResponse : AopResponse
    {
        /// <summary>
        /// 高清图图片ID
        /// </summary>
        [XmlElement("hd_image_id")]
        public string HdImageId { get; set; }
    }
}
