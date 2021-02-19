using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignItemMerchantactivityCloseModel : AopObject
    {
        /// <summary>
        /// 活动id。通过 <a href="https://opendocs.alipay.com/pre-apis/api_pre/koubei.marketing.campaign.item.merchantactivity.create">koubei.marketing.campaign.item.merchantactivity.create</a>(商户创建商品代金券)获取。
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
