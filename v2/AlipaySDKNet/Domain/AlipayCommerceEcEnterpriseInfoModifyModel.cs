using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseInfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEnterpriseInfoModifyModel : AopObject
    {
        /// <summary>
        /// 企业简称
        /// </summary>
        [XmlElement("enterprise_alias")]
        public string EnterpriseAlias { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("enterprise_name")]
        public string EnterpriseName { get; set; }
    }
}
