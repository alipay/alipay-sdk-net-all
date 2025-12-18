using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OBBatchCustomerIdentityDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OBBatchCustomerIdentityDTO : AopObject
    {
        /// <summary>
        /// 企业信息
        /// </summary>
        [XmlElement("company")]
        public OBCompanyDTO Company { get; set; }

        /// <summary>
        /// 通行证ID
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }

        /// <summary>
        /// 个人信息
        /// </summary>
        [XmlElement("personal")]
        public OBPersonalDTO Personal { get; set; }
    }
}
