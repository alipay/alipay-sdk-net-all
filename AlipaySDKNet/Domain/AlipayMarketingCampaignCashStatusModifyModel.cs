using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignCashStatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignCashStatusModifyModel : AopObject
    {
        /// <summary>
        /// 金活动修改后的状态。支持修改为： *PAUSE：活动暂停。 *READY：活动开始。 *CLOSED：活动结束。
        /// </summary>
        [XmlElement("camp_status")]
        public string CampStatus { get; set; }

        /// <summary>
        /// 现金活动号，通过<a href="https://opendocs.alipay.com/apis/api_5/alipay.marketing.campaign.cash.create">alipay.marketing.campaign.cash.create</a>(创建现金活动)接口创建现金活动获取。
        /// </summary>
        [XmlElement("crowd_no")]
        public string CrowdNo { get; set; }
    }
}
