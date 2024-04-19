using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignUnicardCardRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignUnicardCardRefundModel : AopObject
    {
        /// <summary>
        /// 联营卡卡号。 用户在C端开通的联营卡后分配的卡号，目前一个周期的卡号是唯一的，且卡号会对应确定的卡模板id。
        /// </summary>
        [XmlElement("uni_card_no")]
        public string UniCardNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
