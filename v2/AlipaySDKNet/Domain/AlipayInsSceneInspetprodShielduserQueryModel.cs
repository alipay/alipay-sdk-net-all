using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneInspetprodShielduserQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInspetprodShielduserQueryModel : AopObject
    {
        /// <summary>
        /// 场景码-外部场景标识
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 渠道号
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// markid对应的加密字段，防止markid被篡改
        /// </summary>
        [XmlElement("encryption_mark_id")]
        public string EncryptionMarkId { get; set; }

        /// <summary>
        /// 用户识别标识，仅表示唯一编码，不具备业务逻辑和业务含义
        /// </summary>
        [XmlElement("mark_id")]
        public string MarkId { get; set; }
    }
}
