using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMallItemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMallItemQueryModel : AopObject
    {
        /// <summary>
        /// 渠道商商品id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 分销店铺id
        /// </summary>
        [XmlElement("purchaser_id")]
        public string PurchaserId { get; set; }
    }
}
