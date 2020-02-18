using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTravelPromotionGetResponse.
    /// </summary>
    public class AlipayOverseasTravelPromotionGetResponse : AopResponse
    {
        /// <summary>
        /// 优惠信息列表
        /// </summary>
        [XmlArray("promotions")]
        [XmlArrayItem("promotion_info")]
        public List<PromotionInfo> Promotions { get; set; }

        /// <summary>
        /// 入参匹配的优惠总数，分页使用
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
