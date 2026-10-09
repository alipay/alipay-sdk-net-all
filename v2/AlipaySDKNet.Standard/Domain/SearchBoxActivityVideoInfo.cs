using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchBoxActivityVideoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SearchBoxActivityVideoInfo : AopObject
    {
        /// <summary>
        /// 视频按钮文案，2-4个汉字
        /// </summary>
        [XmlElement("video_btn_text")]
        public string VideoBtnText { get; set; }

        /// <summary>
        /// 视频封面图片id，图片id可以通过调用接口alipay.open.file.upload上传图片，获取图片id。图片规范：https://opendocs.alipay.com/mini/operation/atmospheredesign
        /// </summary>
        [XmlElement("video_coverimg_id")]
        public string VideoCoverimgId { get; set; }

        /// <summary>
        /// 视频副标题，2-16个汉字
        /// </summary>
        [XmlElement("video_sub_title")]
        public string VideoSubTitle { get; set; }

        /// <summary>
        /// 视频主标题，2-10个汉字
        /// </summary>
        [XmlElement("video_title")]
        public string VideoTitle { get; set; }
    }
}
