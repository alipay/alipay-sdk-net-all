using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserDtbankcustDailydiscountuserSignupModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserDtbankcustDailydiscountuserSignupModel : AopObject
    {
        /// <summary>
        /// 用户在支付宝实名认证过的支付宝账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 天天减活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
