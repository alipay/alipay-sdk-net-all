using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundCouponWufuCardAcceptModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundCouponWufuCardAcceptModel : AopObject
    {
        /// <summary>
        /// 福卡ID
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 送卡人uid
        /// </summary>
        [XmlElement("sender_user_id")]
        public string SenderUserId { get; set; }

        /// <summary>
        /// 请求来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
