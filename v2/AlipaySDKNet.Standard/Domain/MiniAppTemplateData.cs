using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniAppTemplateData Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppTemplateData : AopObject
    {
        /// <summary>
        /// 小程序名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 图片链接
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 跳转地址
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }

        /// <summary>
        /// logo图片地址
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 小程序标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
