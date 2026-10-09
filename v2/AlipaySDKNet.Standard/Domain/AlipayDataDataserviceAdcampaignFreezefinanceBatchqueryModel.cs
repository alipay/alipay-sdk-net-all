using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignFreezefinanceBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdcampaignFreezefinanceBatchqueryModel : AopObject
    {
        /// <summary>
        /// 二级营销目标
        /// </summary>
        [XmlElement("market_target_code")]
        public string MarketTargetCode { get; set; }

        /// <summary>
        /// 商家标志,唯一值,在广告投放平台商家详情获取
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }
    }
}
