using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AoiInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AoiInfoDTO : AopObject
    {
        /// <summary>
        /// 生活圈名称
        /// </summary>
        [XmlElement("aoi_name")]
        public string AoiName { get; set; }

        /// <summary>
        /// 生活圈标签； 1.aoi类型为非社区：AOI名称； 2.aoi类型为社区：AOI名称/店铺所在的街道路名+离当前主AOI的距离
        /// </summary>
        [XmlElement("aoi_tag")]
        public string AoiTag { get; set; }

        /// <summary>
        /// 生活圈小程序URL链接
        /// </summary>
        [XmlElement("circle_detail_url")]
        public string CircleDetailUrl { get; set; }

        /// <summary>
        /// 生活圈ID
        /// </summary>
        [XmlElement("tribe_id")]
        public string TribeId { get; set; }
    }
}
