using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeServiceRecommendbankQueryResponse.
    /// </summary>
    public class AlipayTradeServiceRecommendbankQueryResponse : AopResponse
    {
        /// <summary>
        /// 推荐银行列表,包含iosSchama,安卓Schama等信息
        /// </summary>
        [XmlArray("recommend_bank_infos")]
        [XmlArrayItem("recommend_bank_info")]
        public List<RecommendBankInfo> RecommendBankInfos { get; set; }
    }
}
