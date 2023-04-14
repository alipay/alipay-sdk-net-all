using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundCouponWufuAipictureMatchResponse.
    /// </summary>
    public class AlipayFundCouponWufuAipictureMatchResponse : AopResponse
    {
        /// <summary>
        /// 是否通过
        /// </summary>
        [XmlElement("pass")]
        public bool Pass { get; set; }
    }
}
