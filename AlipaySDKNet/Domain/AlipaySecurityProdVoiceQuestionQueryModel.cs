using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdVoiceQuestionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdVoiceQuestionQueryModel : AopObject
    {
        /// <summary>
        /// 本轮回答问题,除start阶段外每一轮需要返回用户的回答
        /// </summary>
        [XmlElement("cur_answer")]
        public string CurAnswer { get; set; }

        /// <summary>
        /// 此轮答复类型
        /// </summary>
        [XmlElement("cur_answer_type")]
        public string CurAnswerType { get; set; }

        /// <summary>
        /// 全局唯一标识，触发此回呼的事件，可以是uuid
        /// </summary>
        [XmlElement("event_id")]
        public string EventId { get; set; }

        /// <summary>
        /// 发起阶段还是推进阶段
        /// </summary>
        [XmlElement("phase")]
        public string Phase { get; set; }

        /// <summary>
        /// 场景code,start阶段需要传，服务端以此选取模型启动参数集
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
