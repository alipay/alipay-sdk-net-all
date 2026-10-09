using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineSmddShopCategoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineSmddShopCategoryQueryModel : AopObject
    {
        /// <summary>
        /// 买家唯一标识
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 桌码拓展对象
        /// </summary>
        [XmlElement("code_ext")]
        public CodeExtBean CodeExt { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
