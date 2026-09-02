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

        /// <summary>
        /// 定主体appId
        /// </summary>
        [XmlElement("daily_discount_app_id_specify")]
        public string DailyDiscountAppIdSpecify { get; set; }

        /// <summary>
        /// 用户在指定主体appId对应的openId
        /// </summary>
        [XmlElement("daily_discount_open_id_specify")]
        public string DailyDiscountOpenIdSpecify { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
