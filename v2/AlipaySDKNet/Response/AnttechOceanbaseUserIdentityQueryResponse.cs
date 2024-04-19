using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseUserIdentityQueryResponse.
    /// </summary>
    public class AnttechOceanbaseUserIdentityQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业信息
        /// </summary>
        [XmlElement("company")]
        public OBCompanyDTO Company { get; set; }

        /// <summary>
        /// 个人信息
        /// </summary>
        [XmlElement("personal")]
        public OBPersonalDTO Personal { get; set; }
    }
}
