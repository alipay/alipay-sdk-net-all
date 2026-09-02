using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentHouseBizentitySetResponse.
    /// </summary>
    public class AlipayCommerceRentHouseBizentitySetResponse : AopResponse
    {
        /// <summary>
        /// 特性id
        /// </summary>
        [XmlElement("feature_id")]
        public string FeatureId { get; set; }
    }
}
