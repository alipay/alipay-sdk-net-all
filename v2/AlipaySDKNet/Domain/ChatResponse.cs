using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChatResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ChatResponse : AopObject
    {
        /// <summary>
        /// Agent回答内容
        /// </summary>
        [XmlElement("answer_content")]
        public AnswerContent AnswerContent { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 子agent能力
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
