using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradePaygrowthPayabilityQueryResponse.
    /// </summary>
    public class AlipayTradePaygrowthPayabilityQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否有支付能力，true表示有支付能力，false表示没有支付能力。
        /// </summary>
        [XmlElement("enable_to_pay")]
        public bool EnableToPay { get; set; }

        /// <summary>
        /// 是否需要运营干预，true表示需要运营干预，提供文字链、图片+聚合页、数据等多种干预手段。
        /// </summary>
        [XmlElement("need_recommend")]
        public bool NeedRecommend { get; set; }

        /// <summary>
        /// 支付能力推荐信息，若用户没有支付能力且该场景需要做运营推荐，则返回运营推荐信息，包括推荐类型、文案、图片及跳转地址等。
        /// </summary>
        [XmlElement("recommend_info")]
        public RecommendInfo RecommendInfo { get; set; }
    }
}
