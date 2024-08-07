using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentEnterpriseCertificationQueryResponse.
    /// </summary>
    public class AlipayCommerceRentEnterpriseCertificationQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业认证信息
        /// </summary>
        [XmlElement("rent_enterprise_certification")]
        public RentEnterpriseCertification RentEnterpriseCertification { get; set; }
    }
}
