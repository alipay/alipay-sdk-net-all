using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignPlaysigninSigninModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignPlaysigninSigninModel : AopObject
    {
        /// <summary>
        /// openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制，相同单号会返回上一次的结果，接入方需保证单号唯一。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 签到玩法ID
        /// </summary>
        [XmlElement("signin_play_id")]
        public string SigninPlayId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
