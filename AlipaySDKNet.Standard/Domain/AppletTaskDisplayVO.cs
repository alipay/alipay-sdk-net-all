using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppletTaskDisplayVO Data Structure.
    /// </summary>
    [Serializable]
    public class AppletTaskDisplayVO : AopObject
    {
        /// <summary>
        /// 显示的任务未完成时的按钮文本。
        /// </summary>
        [XmlElement("button_text")]
        public string ButtonText { get; set; }

        /// <summary>
        /// 显示的任务已完成时的按钮文本。
        /// </summary>
        [XmlElement("button_text_disabled")]
        public string ButtonTextDisabled { get; set; }

        /// <summary>
        /// 任务跳转链接。
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }

        /// <summary>
        /// 业务链接。
        /// </summary>
        [XmlElement("promo_link")]
        public string PromoLink { get; set; }

        /// <summary>
        /// 任务标签图标链接。
        /// </summary>
        [XmlElement("tag_icon")]
        public string TagIcon { get; set; }

        /// <summary>
        /// 任务标签后缀文案。
        /// </summary>
        [XmlElement("tag_suffix")]
        public string TagSuffix { get; set; }

        /// <summary>
        /// 显示的任务描述。
        /// </summary>
        [XmlElement("task_desc")]
        public string TaskDesc { get; set; }

        /// <summary>
        /// 显示的任务图标链接。
        /// </summary>
        [XmlElement("task_icon")]
        public string TaskIcon { get; set; }

        /// <summary>
        /// 显示的任务名称
        /// </summary>
        [XmlElement("task_title")]
        public string TaskTitle { get; set; }
    }
}
