using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserGameopenpromoChallengeSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserGameopenpromoChallengeSubmitModel : AopObject
    {
        /// <summary>
        /// 用户维度的参与挑战业务号，发奖会以此业务号做幂等
        /// </summary>
        [XmlElement("challenge_biz_no")]
        public string ChallengeBizNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝唯一用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
