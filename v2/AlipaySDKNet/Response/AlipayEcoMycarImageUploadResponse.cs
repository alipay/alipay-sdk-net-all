using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarImageUploadResponse.
    /// </summary>
    public class AlipayEcoMycarImageUploadResponse : AopResponse
    {
        /// <summary>
        /// 图片Id
        /// </summary>
        [XmlElement("img_id")]
        public string ImgId { get; set; }

        /// <summary>
        /// 图片地址，url全是小写
        /// </summary>
        [XmlElement("img_url")]
        public string ImgUrl { get; set; }
    }
}
