using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GuessQuestion Data Structure.
    /// </summary>
    [Serializable]
    public class GuessQuestion : AopObject
    {
        /// <summary>
        /// 问题内容
        /// </summary>
        [XmlElement("question_content")]
        public string QuestionContent { get; set; }

        /// <summary>
        /// 问题唯一标识
        /// </summary>
        [XmlElement("question_id")]
        public string QuestionId { get; set; }

        /// <summary>
        /// 问题类型
        /// </summary>
        [XmlElement("question_type")]
        public string QuestionType { get; set; }

        /// <summary>
        /// 场景唯一标识
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }
    }
}
