using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAichatSyncmsgCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAichatSyncmsgCreateModel : AopObject
    {
        /// <summary>
        /// 业务场景信息
        /// </summary>
        [XmlElement("biz_trans_data")]
        public string BizTransData { get; set; }

        /// <summary>
        /// 提问类型。
        /// </summary>
        [XmlElement("chat_type")]
        public string ChatType { get; set; }

        /// <summary>
        /// 客户唯一标识，由客户提供
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 用户提问内容
        /// </summary>
        [XmlElement("question")]
        public string Question { get; set; }

        /// <summary>
        /// 场景ID，该字段由和客户约定产生。
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 会话ID，标识一通包含多轮对话的问答。该字段为可选自选，若客户自行进行会话管理，则传入该字段；若不传该字段，则由问答系统进行会话管理。
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
