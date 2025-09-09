using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAichatHotspotQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAichatHotspotQueryModel : AopObject
    {
        /// <summary>
        /// 客户唯一标识
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 问答服务的场景ID
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }
    }
}
