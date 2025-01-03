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
        /// 骑手平台
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
