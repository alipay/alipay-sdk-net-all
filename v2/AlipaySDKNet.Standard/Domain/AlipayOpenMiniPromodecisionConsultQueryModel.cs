using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniPromodecisionConsultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniPromodecisionConsultQueryModel : AopObject
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlElement("item_detail_info")]
        public ItemDetailInfo ItemDetailInfo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部优惠信息
        /// </summary>
        [XmlElement("out_promo_info")]
        public OutPromoInfo OutPromoInfo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
