using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignPlaysigninCountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignPlaysigninCountQueryModel : AopObject
    {
        /// <summary>
        /// openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 签到玩法ID
        /// </summary>
        [XmlElement("signin_play_id")]
        public string SigninPlayId { get; set; }

        /// <summary>
        /// 出资的支付宝用户id 限制: 1、登录账号和用户ID必须且只能二选一
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
