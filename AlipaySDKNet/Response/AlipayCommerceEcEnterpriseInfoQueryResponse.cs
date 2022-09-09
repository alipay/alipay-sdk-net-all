using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseInfoQueryResponse.
    /// </summary>
    public class AlipayCommerceEcEnterpriseInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业信息
        /// </summary>
        [XmlElement("enterprise_info")]
        public EnterpriseInfoDTO EnterpriseInfo { get; set; }
    }
}
