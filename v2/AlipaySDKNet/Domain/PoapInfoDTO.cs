using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PoapInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PoapInfoDTO : AopObject
    {
        /// <summary>
        /// 勋章id
        /// </summary>
        [XmlElement("medal_id")]
        public string MedalId { get; set; }

        /// <summary>
        /// 勋章meta信息编码
        /// </summary>
        [XmlElement("medal_meta_id")]
        public long MedalMetaId { get; set; }

        /// <summary>
        /// 勋章名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 缩略图
        /// </summary>
        [XmlElement("thumbnail_url")]
        public string ThumbnailUrl { get; set; }
    }
}
