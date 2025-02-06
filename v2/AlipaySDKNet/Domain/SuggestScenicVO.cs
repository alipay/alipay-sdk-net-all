using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SuggestScenicVO Data Structure.
    /// </summary>
    [Serializable]
    public class SuggestScenicVO : AopObject
    {
        /// <summary>
        /// 观景图
        /// </summary>
        [XmlElement("suggest_pic_url")]
        public string SuggestPicUrl { get; set; }

        /// <summary>
        /// 评分
        /// </summary>
        [XmlElement("suggest_rating")]
        public string SuggestRating { get; set; }

        /// <summary>
        /// 建议时间
        /// </summary>
        [XmlElement("suggest_time")]
        public string SuggestTime { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("suggest_title")]
        public string SuggestTitle { get; set; }
    }
}
