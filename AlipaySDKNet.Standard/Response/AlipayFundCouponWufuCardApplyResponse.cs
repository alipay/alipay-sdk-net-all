using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundCouponWufuCardApplyResponse.
    /// </summary>
    public class AlipayFundCouponWufuCardApplyResponse : AopResponse
    {
        /// <summary>
        /// 请求成功（未返回错误码时），该值不为空，为奖品列表信息；若该值为空，可联系五福排查
        /// </summary>
        [XmlArray("prize_list")]
        [XmlArrayItem("common_prize_vo")]
        public List<CommonPrizeVo> PrizeList { get; set; }
    }
}
