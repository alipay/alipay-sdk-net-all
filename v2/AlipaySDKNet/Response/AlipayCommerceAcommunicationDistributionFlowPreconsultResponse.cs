using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationDistributionFlowPreconsultResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationDistributionFlowPreconsultResponse : AopResponse
    {
        /// <summary>
        /// 手机号对应多用户标志
        /// </summary>
        [XmlElement("mobile_mapping_multi_user")]
        public bool MobileMappingMultiUser { get; set; }
    }
}
