using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneEcommerceInsureRecommendResponse.
    /// </summary>
    public class AlipayInsSceneEcommerceInsureRecommendResponse : AopResponse
    {
        /// <summary>
        /// 推荐结果
        /// </summary>
        [XmlArray("recommend_results")]
        [XmlArrayItem("insure_recomm_result_d_t_o")]
        public List<InsureRecommResultDTO> RecommendResults { get; set; }
    }
}
