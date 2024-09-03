using System;
using System.Xml.Serialization;
using System.Collections.Generic;
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

        /// <summary>
        /// 企业认证信息列表
        /// </summary>
        [XmlArray("rent_enterprise_certification_list")]
        [XmlArrayItem("rent_enterprise_certification")]
        public List<RentEnterpriseCertification> RentEnterpriseCertificationList { get; set; }
    }
}
