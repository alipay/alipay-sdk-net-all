using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayAppBainaPrizePreconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayAppBainaPrizePreconsultModel : AopObject
    {
        /// <summary>
        /// 从下单url的扩展extJson中获取，key=activityId，此接口带回
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 用户下单的商品id,用于确认用户是否可对该商品进行下单
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

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
