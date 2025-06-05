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
        /// 骑手所属平台
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }
    }
}
