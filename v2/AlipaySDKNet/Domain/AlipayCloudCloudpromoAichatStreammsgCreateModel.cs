using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAichatStreammsgCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAichatStreammsgCreateModel : AopObject
    {
        /// <summary>
        /// 业务场景信息
        /// </summary>
        [XmlElement("biz_trans_data")]
        public string BizTransData { get; set; }

        /// <summary>
        /// 提问内容是文本还是语音。
        /// </summary>
        [XmlElement("chat_type")]
        public string ChatType { get; set; }

        /// <summary>
        /// 客户唯一标识,该字段由客户生成并提供。
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 用户提问内容
        /// </summary>
        [XmlElement("question")]
        public string Question { get; set; }

        /// <summary>
        /// 一次请求全局唯一标识。如果为空，系统会默认生成，如果不为空，则使用传入的requestID作为唯一标识。如果重试字段retry为true，则此字段必传，表示需要重试的记录
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 当前请求是否是重试请求，如果为true，则requestId必须不为空，且为需要重试的请求。其他情况可以不传此字段
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }

        /// <summary>
        /// 场景ID，该字段由问答系统生成并给到业务方使用。
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 会话ID。该字段由问答系统生成。
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 原始请求的appID
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }
    }
}
