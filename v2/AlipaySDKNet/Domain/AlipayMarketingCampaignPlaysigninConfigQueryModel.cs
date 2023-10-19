using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignPlaysigninConfigQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignPlaysigninConfigQueryModel : AopObject
    {
        /// <summary>
        /// openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 玩法ID
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
