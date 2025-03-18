using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationDiscountPhoneRecommendResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationDiscountPhoneRecommendResponse : AopResponse
    {
        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 询价返回的商品信息
        /// </summary>
        [XmlArray("recommend_item_info")]
        [XmlArrayItem("recommend_item_info")]
        public List<RecommendItemInfo> RecommendItemInfo { get; set; }

        /// <summary>
        /// 分层商品信息
        /// </summary>
        [XmlElement("recommend_layered_item_info")]
        public RecommendLayeredItemResponse RecommendLayeredItemInfo { get; set; }
    }
}
