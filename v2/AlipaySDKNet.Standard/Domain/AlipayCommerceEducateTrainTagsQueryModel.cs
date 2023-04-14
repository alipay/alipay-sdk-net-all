using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTrainTagsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateTrainTagsQueryModel : AopObject
    {
        /// <summary>
        /// 场景类型
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
