using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicShortlinkCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicShortlinkCreateModel : AopObject
    {
        /// <summary>
        /// 对于场景ID的描述，由商户自定义。
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 短链接对应的场景ID。由商户自定义，仅支持数字、字母及下划线。
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }
    }
}
