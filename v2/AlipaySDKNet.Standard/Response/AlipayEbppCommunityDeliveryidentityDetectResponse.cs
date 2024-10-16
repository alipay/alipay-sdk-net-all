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
    }
}
