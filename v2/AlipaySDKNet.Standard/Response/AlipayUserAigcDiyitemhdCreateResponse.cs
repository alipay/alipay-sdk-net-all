using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAigcDiyitemhdCreateResponse.
    /// </summary>
    public class AlipayUserAigcDiyitemhdCreateResponse : AopResponse
    {
        /// <summary>
        /// 多媒体高清图ID
        /// </summary>
        [XmlElement("hd_image_id")]
        public string HdImageId { get; set; }
    }
}
