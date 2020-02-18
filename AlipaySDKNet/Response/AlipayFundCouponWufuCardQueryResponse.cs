using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundCouponWufuCardQueryResponse.
    /// </summary>
    public class AlipayFundCouponWufuCardQueryResponse : AopResponse
    {
        /// <summary>
        /// 领取福卡总数
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }
    }
}
