using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoTravelPicCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoTravelPicCreateModel : AopObject
    {
        /// <summary>
        /// 页脚标题
        /// </summary>
        [XmlElement("footer_title")]
        public string FooterTitle { get; set; }

        /// <summary>
        /// 头像链接
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// tab1图片
        /// </summary>
        [XmlElement("pic_1")]
        public string Pic1 { get; set; }

        /// <summary>
        /// tab2图片
        /// </summary>
        [XmlElement("pic_2")]
        public string Pic2 { get; set; }

        /// <summary>
        /// tab3图片
        /// </summary>
        [XmlElement("pic_3")]
        public string Pic3 { get; set; }

        /// <summary>
        /// tab4图片
        /// </summary>
        [XmlElement("pic_4")]
        public string Pic4 { get; set; }

        /// <summary>
        /// 页面标题
        /// </summary>
        [XmlElement("share_desc")]
        public string ShareDesc { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 文案1
        /// </summary>
        [XmlElement("text_1")]
        public string Text1 { get; set; }

        /// <summary>
        /// 文案2
        /// </summary>
        [XmlElement("text_2")]
        public string Text2 { get; set; }

        /// <summary>
        /// 文案3
        /// </summary>
        [XmlElement("text_3")]
        public string Text3 { get; set; }

        /// <summary>
        /// 文案4
        /// </summary>
        [XmlElement("text_4")]
        public string Text4 { get; set; }
    }
}
