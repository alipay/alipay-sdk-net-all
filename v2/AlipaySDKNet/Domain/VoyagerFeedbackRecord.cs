using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoyagerFeedbackRecord Data Structure.
    /// </summary>
    [Serializable]
    public class VoyagerFeedbackRecord : AopObject
    {
        /// <summary>
        /// 反馈信息
        /// </summary>
        [XmlElement("feedback_ext_info")]
        public string FeedbackExtInfo { get; set; }

        /// <summary>
        /// 反馈类型，show:曝光, click:点击
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
