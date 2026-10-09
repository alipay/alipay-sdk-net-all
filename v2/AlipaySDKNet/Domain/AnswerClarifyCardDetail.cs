using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnswerClarifyCardDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AnswerClarifyCardDetail : AopObject
    {
        /// <summary>
        /// 澄清卡片，多轮问答的反问内容。
        /// </summary>
        [XmlArray("dst_list")]
        [XmlArrayItem("string")]
        public List<string> DstList { get; set; }

        /// <summary>
        /// 关注的问题。澄清卡片前置文案
        /// </summary>
        [XmlElement("follow_question")]
        public string FollowQuestion { get; set; }
    }
}
