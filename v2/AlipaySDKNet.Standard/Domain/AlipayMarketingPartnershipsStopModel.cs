using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingPartnershipsStopModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingPartnershipsStopModel : AopObject
    {
        /// <summary>
        /// 本次终止授权给合作方的营销资源。
        /// </summary>
        [XmlElement("authorized_data")]
        public MarketingAuthorizedData AuthorizedData { get; set; }

        /// <summary>
        /// 合作方相关信息
        /// </summary>
        [XmlElement("partner")]
        public MarketingPartner Partner { get; set; }
    }
}
