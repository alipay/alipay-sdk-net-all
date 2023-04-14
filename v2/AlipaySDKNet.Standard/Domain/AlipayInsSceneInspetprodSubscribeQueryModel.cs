using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneInspetprodSubscribeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInspetprodSubscribeQueryModel : AopObject
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
        /// 用户识别标识加密字段
        /// </summary>
        [XmlElement("encryption_mark_id")]
        public string EncryptionMarkId { get; set; }

        /// <summary>
        /// 用户识别标识
        /// </summary>
        [XmlElement("mark_id")]
        public string MarkId { get; set; }
    }
}
