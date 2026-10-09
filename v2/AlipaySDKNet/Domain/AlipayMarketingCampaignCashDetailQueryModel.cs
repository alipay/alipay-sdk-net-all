using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignCashDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignCashDetailQueryModel : AopObject
    {
        /// <summary>
        /// 现金活动号，通过<a href="https://opendocs.alipay.com/apis/api_5/alipay.marketing.campaign.cash.create">alipay.marketing.campaign.cash.create</a>(创建现金活动)接口创建现金活动获取。
        /// </summary>
        [XmlElement("crowd_no")]
        public string CrowdNo { get; set; }
    }
}
