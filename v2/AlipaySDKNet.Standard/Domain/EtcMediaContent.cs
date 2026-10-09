using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EtcMediaContent Data Structure.
    /// </summary>
    [Serializable]
    public class EtcMediaContent : AopObject
    {
        /// <summary>
        /// "VIO_IDCARD_FRONT":"车主身份证正面照" "VIO_IDCARD_BACK":"车主身份证反面照" "VI_LICENSE_FRONT":"行驶证正页" "VI_LICENSE_VICE":"行驶证副页" "VI_PHOTO_45":"车头45度照片"
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 资料base64值
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
