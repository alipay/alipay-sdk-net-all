using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalAdvisoragentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalAdvisoragentQueryModel : AopObject
    {
        /// <summary>
        /// 额外字段
        /// </summary>
        [XmlElement("biz_info_entity")]
        public Entity BizInfoEntity { get; set; }

        /// <summary>
        /// 对话ID，传递本次场景交互的唯一对话ID
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 外部用户ID
        /// </summary>
        [XmlElement("out_open_id")]
        public string OutOpenId { get; set; }

        /// <summary>
        /// 外部用户ID
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 会话ID，传递本次交互的唯一会话ID
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 场景技能名称
        /// </summary>
        [XmlElement("skill")]
        public string Skill { get; set; }
    }
}
