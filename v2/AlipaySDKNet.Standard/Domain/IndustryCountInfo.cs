using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndustryCountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryCountInfo : AopObject
    {
        /// <summary>
        /// 集团成员行业分布
        /// </summary>
        [XmlArray("member_industry")]
        [XmlArrayItem("ep_indicator_industry_count_info")]
        public List<EpIndicatorIndustryCountInfo> MemberIndustry { get; set; }

        /// <summary>
        /// 集团参股20%以上的企业行业分布
        /// </summary>
        [XmlArray("nephew_industry")]
        [XmlArrayItem("ep_indicator_industry_count_info")]
        public List<EpIndicatorIndustryCountInfo> NephewIndustry { get; set; }

        /// <summary>
        /// 集团参股20%以下的企业行业分布
        /// </summary>
        [XmlArray("unrelated_industry")]
        [XmlArrayItem("ep_indicator_industry_count_info")]
        public List<EpIndicatorIndustryCountInfo> UnrelatedIndustry { get; set; }
    }
}
