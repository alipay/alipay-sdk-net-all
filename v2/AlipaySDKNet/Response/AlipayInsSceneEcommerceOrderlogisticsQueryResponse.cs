using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneEcommerceOrderlogisticsQueryResponse.
    /// </summary>
    public class AlipayInsSceneEcommerceOrderlogisticsQueryResponse : AopResponse
    {
        /// <summary>
        /// 物流单摘要
        /// </summary>
        [XmlElement("logistics_digest")]
        public InsOpenLogisticsDigestDTO LogisticsDigest { get; set; }
    }
}
