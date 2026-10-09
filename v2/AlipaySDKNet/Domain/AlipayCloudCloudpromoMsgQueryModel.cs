using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMsgQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMsgQueryModel : AopObject
    {
        /// <summary>
        /// 用户对应的openId
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 租房小程序模版id
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 业务的小程序id
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }
    }
}
