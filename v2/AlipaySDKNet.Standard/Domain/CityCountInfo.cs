using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CityCountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CityCountInfo : AopObject
    {
        /// <summary>
        /// 集团成员地区分布
        /// </summary>
        [XmlArray("member_province")]
        [XmlArrayItem("ep_indicator_city_count_info")]
        public List<EpIndicatorCityCountInfo> MemberProvince { get; set; }

        /// <summary>
        /// 集团参股20%以上的企业地区分布
        /// </summary>
        [XmlArray("nephew_province")]
        [XmlArrayItem("ep_indicator_city_count_info")]
        public List<EpIndicatorCityCountInfo> NephewProvince { get; set; }

        /// <summary>
        /// 集团参股20%以下的企业地区分布
        /// </summary>
        [XmlArray("unrelated_province")]
        [XmlArrayItem("ep_indicator_city_count_info")]
        public List<EpIndicatorCityCountInfo> UnrelatedProvince { get; set; }
    }
}
