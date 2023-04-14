using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEnterpriseInfoQueryModel : AopObject
    {
        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }
    }
}
