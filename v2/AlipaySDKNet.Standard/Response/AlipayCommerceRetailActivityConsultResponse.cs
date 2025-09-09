using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRetailActivityConsultResponse.
    /// </summary>
    public class AlipayCommerceRetailActivityConsultResponse : AopResponse
    {
        /// <summary>
        /// 积分奖品信息列表
        /// </summary>
        [XmlArray("point_prize_info")]
        [XmlArrayItem("retail_point_prize_info_d_t_o")]
        public List<RetailPointPrizeInfoDTO> PointPrizeInfo { get; set; }
    }
}
