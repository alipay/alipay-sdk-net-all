using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneFinresearchConsultFeedbackCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneFinresearchConsultFeedbackCreateModel : AopObject
    {
        /// <summary>
        /// 回答
        /// </summary>
        [XmlElement("answer")]
        public string Answer { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        [XmlElement("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// 咨询ID
        /// </summary>
        [XmlElement("consult_id")]
        public string ConsultId { get; set; }

        /// <summary>
        /// 本次会话的主体ID
        /// </summary>
        [XmlElement("identity_id")]
        public string IdentityId { get; set; }

        /// <summary>
        /// 反馈类型
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 原始问题
        /// </summary>
        [XmlElement("question")]
        public string Question { get; set; }

        /// <summary>
        /// 会话ID
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
