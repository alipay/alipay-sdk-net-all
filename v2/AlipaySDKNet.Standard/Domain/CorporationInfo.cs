using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CorporationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CorporationInfo : AopObject
    {
        /// <summary>
        /// 企业税务局税号
        /// </summary>
        [XmlElement("enterprise_registration_no")]
        public string EnterpriseRegistrationNo { get; set; }
    }
}
