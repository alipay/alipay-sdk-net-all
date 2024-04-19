using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryGovserviceRecommendQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryGovserviceRecommendQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// token值
        /// </summary>
        [XmlElement("recommend_token")]
        public string RecommendToken { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
