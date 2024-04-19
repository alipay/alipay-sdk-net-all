using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TechriskInnovateMpcpromoOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class TechriskInnovateMpcpromoOrderCreateModel : AopObject
    {
        /// <summary>
        /// 由调用方定义的用户，可以使用用户名或者商户自定义用户id
        /// </summary>
        [XmlElement("buyer")]
        public string Buyer { get; set; }

        /// <summary>
        /// 商家商品id
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商家侧skuId
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 购买数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }
    }
}
