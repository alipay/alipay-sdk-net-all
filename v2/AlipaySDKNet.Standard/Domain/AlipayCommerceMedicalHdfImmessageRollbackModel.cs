using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfImmessageRollbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfImmessageRollbackModel : AopObject
    {
        /// <summary>
        /// 发送者账号ID（SDK撤回时必填）
        /// </summary>
        [XmlElement("from_source_id")]
        public string FromSourceId { get; set; }

        /// <summary>
        /// 发送者账号类型（SDK撤回时必填）
        /// </summary>
        [XmlElement("from_source_type")]
        public string FromSourceType { get; set; }

        /// <summary>
        /// 方法动作: revoke-服务端撤回, revokeForSDK-SDK撤回
        /// </summary>
        [XmlElement("method_action")]
        public string MethodAction { get; set; }

        /// <summary>
        /// 消息ID
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 是否需要分发消息
        /// </summary>
        [XmlElement("need_distribute")]
        public bool NeedDistribute { get; set; }

        /// <summary>
        /// 接收者账号ID
        /// </summary>
        [XmlElement("to_source_id")]
        public string ToSourceId { get; set; }

        /// <summary>
        /// 接收者账号类型
        /// </summary>
        [XmlElement("to_source_type")]
        public string ToSourceType { get; set; }

        /// <summary>
        /// 用户ID（SDK撤回时必填）
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
