using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsMarketingProductRecommendResponse.
    /// </summary>
    public class AlipayInsMarketingProductRecommendResponse : AopResponse
    {
        /// <summary>
        /// 产品列表
        /// </summary>
        [XmlArray("products")]
        [XmlArrayItem("recom_product")]
        public List<RecomProduct> Products { get; set; }

        /// <summary>
        /// 推荐流水号
        /// </summary>
        [XmlElement("recom_flow_no")]
        public string RecomFlowNo { get; set; }
    }
}
