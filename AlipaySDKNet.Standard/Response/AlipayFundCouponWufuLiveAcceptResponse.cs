using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundCouponWufuLiveAcceptResponse.
    /// </summary>
    public class AlipayFundCouponWufuLiveAcceptResponse : AopResponse
    {
        /// <summary>
        /// 奖品列表信息，prized=true时取第一个
        /// </summary>
        [XmlArray("prize_list")]
        [XmlArrayItem("common_prize_model_vo")]
        public List<CommonPrizeModelVo> PrizeList { get; set; }

        /// <summary>
        /// 是否中奖
        /// </summary>
        [XmlElement("prized")]
        public bool Prized { get; set; }
    }
}
