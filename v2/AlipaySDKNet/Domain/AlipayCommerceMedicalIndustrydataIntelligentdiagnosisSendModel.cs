using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataIntelligentdiagnosisSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndustrydataIntelligentdiagnosisSendModel : AopObject
    {
        /// <summary>
        /// 对话chatId，若是修改的，则传，正常流程不传
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 用户id映射
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部用户user的唯一表示： 1. 如果能获取到用户uid就传支付宝uid 2. 如果获取不到支付宝uid，就用内部用户id，看是否可以加个通用标识，比如ET（外端）； 3. 获取不到用户id时，不同的用户访问时，不能传固定id，可以生成一个随机不重复的数，前缀增加个ET-UR-xxx，以便后续区分
        /// </summary>
        [XmlElement("outer_user_no")]
        public string OuterUserNo { get; set; }

        /// <summary>
        /// 外部用户类型，用于区分是2088xxx支付宝用户或其他数值
        /// </summary>
        [XmlElement("outer_user_type")]
        public string OuterUserType { get; set; }

        /// <summary>
        /// 回答内容
        /// </summary>
        [XmlElement("question")]
        public string Question { get; set; }

        /// <summary>
        /// 问题类型
        /// </summary>
        [XmlElement("question_type")]
        public string QuestionType { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 请求来源，固定参数
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }
    }
}
