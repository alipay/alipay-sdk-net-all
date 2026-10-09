using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SceneSubArea Data Structure.
    /// </summary>
    [Serializable]
    public class SceneSubArea : AopObject
    {
        /// <summary>
        /// 区域id
        /// </summary>
        [XmlElement("area_id")]
        public string AreaId { get; set; }

        /// <summary>
        /// 区域名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 该子区域内部的推荐点位id
        /// </summary>
        [XmlElement("recommend_spot_id")]
        public string RecommendSpotId { get; set; }
    }
}
