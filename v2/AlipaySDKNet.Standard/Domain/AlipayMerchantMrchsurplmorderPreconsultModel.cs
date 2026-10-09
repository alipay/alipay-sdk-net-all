using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantMrchsurplmorderPreconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantMrchsurplmorderPreconsultModel : AopObject
    {
        /// <summary>
        /// LinkedMall入驻的业务ID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// LinkedMall的商品ID
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 订单扩展属性信息
        /// </summary>
        [XmlElement("merchant_exts")]
        public string MerchantExts { get; set; }

        /// <summary>
        /// LinkedMall的skuId
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
