using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TinyAppMsgVO Data Structure.
    /// </summary>
    [Serializable]
    public class TinyAppMsgVO : AopObject
    {
        /// <summary>
        /// 对推送商品的简单介绍（参考：美妆好物应有尽有，快戳进来看看呀）
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 建议选择有吸引力的图片，引导用户点击链接（支持的图片 jpg、png，400*200，限制1M以内) 当前字段已废弃(初始创建不规范，不曾用到)
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
        /// 应用id。用于入群欢迎语在群里展示。
        /// </summary>
        [XmlElement("tiny_app_id")]
        public string TinyAppId { get; set; }

        /// <summary>
        /// 用于入群欢迎语的消息展示。
        /// </summary>
        [XmlElement("tiny_app_logo")]
        public string TinyAppLogo { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [XmlElement("tiny_app_name")]
        public string TinyAppName { get; set; }

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
