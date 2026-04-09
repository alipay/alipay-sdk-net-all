using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcBalanceAlertCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcBalanceAlertCheckModel : AopObject
    {
        /// <summary>
        /// 企业码企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }
    }
}
