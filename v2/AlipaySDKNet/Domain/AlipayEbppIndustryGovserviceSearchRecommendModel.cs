using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryGovserviceSearchRecommendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryGovserviceSearchRecommendModel : AopObject
    {
        /// <summary>
        /// 服务展示渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 当其他端不支持支付宝uid时，用于标识用户的唯一标识
        /// </summary>
        [XmlElement("identify_id")]
        public string IdentifyId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户搜索内容
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 用户query和服务相关性的最低分数。大模型会返回相关性大于该值的服务信息
        /// </summary>
        [XmlElement("search_score")]
        public string SearchScore { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
