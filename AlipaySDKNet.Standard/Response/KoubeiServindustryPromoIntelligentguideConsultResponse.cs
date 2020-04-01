using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiServindustryPromoIntelligentguideConsultResponse.
    /// </summary>
    public class KoubeiServindustryPromoIntelligentguideConsultResponse : AopResponse
    {
        /// <summary>
        /// 预计消费最大金额
        /// </summary>
        [XmlElement("consume_max")]
        public long ConsumeMax { get; set; }

        /// <summary>
        /// 预计最少消费金额
        /// </summary>
        [XmlElement("consume_min")]
        public long ConsumeMin { get; set; }

        /// <summary>
        /// 推荐卡项信息
        /// </summary>
        [XmlElement("recommend_card")]
        public RecommendCard RecommendCard { get; set; }

        /// <summary>
        /// 推荐具体服务项目
        /// </summary>
        [XmlArray("recommend_service_info")]
        [XmlArrayItem("recommend_service_info")]
        public List<RecommendServiceInfo> RecommendServiceInfo { get; set; }

        /// <summary>
        /// 用户兴趣标签，多个用'|' 分隔符分隔
        /// </summary>
        [XmlElement("user_tags")]
        public string UserTags { get; set; }
    }
}
