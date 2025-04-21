using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingBusinessbillGoodsDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingBusinessbillGoodsDeleteModel : AopObject
    {
        /// <summary>
        /// 支付宝分配的场景编码
        /// </summary>
        [XmlElement("activity_scene")]
        public string ActivityScene { get; set; }

        /// <summary>
        /// 失效商品id，定位商品的唯一凭证
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

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
