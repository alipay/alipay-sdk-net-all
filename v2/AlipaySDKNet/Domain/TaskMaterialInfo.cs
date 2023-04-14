using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskMaterialInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TaskMaterialInfo : AopObject
    {
        /// <summary>
        /// 任务领奖按钮文案
        /// </summary>
        [XmlElement("button_text_award")]
        public string ButtonTextAward { get; set; }

        /// <summary>
        /// 任务已结束按钮文案
        /// </summary>
        [XmlElement("button_text_done")]
        public string ButtonTextDone { get; set; }

        /// <summary>
        /// 任务报名按钮文案
        /// </summary>
        [XmlElement("button_text_signup")]
        public string ButtonTextSignup { get; set; }

        /// <summary>
        /// 任务图标地址
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 任务跳转链接
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }

        /// <summary>
        /// 任务副标题
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 任务主标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
