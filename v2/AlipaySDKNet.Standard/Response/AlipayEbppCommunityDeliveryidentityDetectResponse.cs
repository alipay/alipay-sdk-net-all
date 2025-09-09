using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppCommunityDeliveryidentityDetectResponse.
    /// </summary>
    public class AlipayEbppCommunityDeliveryidentityDetectResponse : AopResponse
    {
        /// <summary>
        /// 在该小区是否有单
        /// </summary>
        [XmlElement("detect_result")]
        public bool DetectResult { get; set; }

        /// <summary>
        /// 与平台方合作，通过个人手机号或者身份信息，查询个人是否为该平台骑手身份以及在指定区域和时间范围内是否有订单。
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }
    }
}
