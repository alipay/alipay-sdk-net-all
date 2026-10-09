using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAichatFileDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAichatFileDeleteModel : AopObject
    {
        /// <summary>
        /// 客户唯一标识
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 文件唯一标识
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 场景ID
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }
    }
}
