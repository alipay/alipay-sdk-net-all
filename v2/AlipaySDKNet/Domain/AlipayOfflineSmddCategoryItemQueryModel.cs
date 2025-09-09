using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineSmddCategoryItemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineSmddCategoryItemQueryModel : AopObject
    {
        /// <summary>
        /// 买家唯一标识
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 商品类目id
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

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
