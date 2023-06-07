using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAccountAvatarPictureCreateResponse.
    /// </summary>
    public class AlipayUserAccountAvatarPictureCreateResponse : AopResponse
    {
        /// <summary>
        /// 云渲染生成图片url
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }
    }
}
