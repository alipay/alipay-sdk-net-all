using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcMarketRegionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcMarketRegionQueryModel : AopObject
    {
        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// DINGDING_SIGN_PAGE（钉钉员企签约页） DINGDING_BENEFIT_PAGE（钉钉权益列表页）
        /// </summary>
        [XmlElement("region_position")]
        public string RegionPosition { get; set; }
    }
}
