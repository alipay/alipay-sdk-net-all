using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniMarketMultibundleConsultResponse.
    /// </summary>
    public class AlipayOpenMiniMarketMultibundleConsultResponse : AopResponse
    {
        /// <summary>
        /// 端ID
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 不同场景命中的营销信息列表
        /// </summary>
        [XmlArray("market_result_list")]
        [XmlArrayItem("market_result")]
        public List<MarketResult> MarketResultList { get; set; }

        /// <summary>
        /// 商户小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
