using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCommunityDeliveryrecentorderDetectResponse.
    /// </summary>
    public class AlipayEbppIndustryCommunityDeliveryrecentorderDetectResponse : AopResponse
    {
        /// <summary>
        /// 与平台方合作，通过个人手机号或者身份信息，查询个人是否为该平台骑手身份以及在指定区域和时间范围内是否有订单。
        /// </summary>
        [XmlElement("delivery_platform")]
        public string DeliveryPlatform { get; set; }

        /// <summary>
        /// 标识骑手来源
        /// </summary>
        [XmlElement("delivery_type")]
        public string DeliveryType { get; set; }

        /// <summary>
        /// true：骑手 false: 非骑手
        /// </summary>
        [XmlElement("detect_result")]
        public bool DetectResult { get; set; }
    }
}
