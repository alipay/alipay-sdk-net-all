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
        /// 提问类型 如果值为AUDIO，quesiton字段值为经过base64之后的语音流
        /// </summary>
        [XmlElement("chat_type")]
        public string ChatType { get; set; }

        /// <summary>
        /// 客户唯一标识
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 用户提问内容
        /// </summary>
        [XmlElement("question")]
        public string Question { get; set; }

        /// <summary>
        /// 场景ID
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 会话ID
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
