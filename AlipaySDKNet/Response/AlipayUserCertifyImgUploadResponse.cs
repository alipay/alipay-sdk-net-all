using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCertifyImgUploadResponse.
    /// </summary>
    public class AlipayUserCertifyImgUploadResponse : AopResponse
    {
        /// <summary>
        /// 图片上传成功后，返回的图片地址
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }
    }
}
