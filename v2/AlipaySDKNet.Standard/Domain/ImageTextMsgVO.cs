using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ImageTextMsgVO Data Structure.
    /// </summary>
    [Serializable]
    public class ImageTextMsgVO : AopObject
    {
        /// <summary>
        /// 对推送商品的简单介绍（参考：美妆好物应有尽有，快戳进来看看呀）
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 建议选择有吸引力的图片，引导用户点击链接（支持的图片 jpg、png，400*200，限制1M以内)
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 图片id
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// 建议选择有吸引力的图片，引导用户点击链接（支持的图片 jpg、png，限制1M以内)
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 文字链接组合
        /// </summary>
        [XmlArray("text_link_list")]
        [XmlArrayItem("text_link_v_o")]
        public List<TextLinkVO> TextLinkList { get; set; }

        /// <summary>
        /// 推送的消息文案标题（参考：好物分享来咯！）
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 自定义链接或小程序页面链接（自定义链接请输入http,https或alipays开头的链接）
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
