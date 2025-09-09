using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LinkedMallItemBaseSku Data Structure.
    /// </summary>
    [Serializable]
    public class LinkedMallItemBaseSku : AopObject
    {
        /// <summary>
        /// 是否可以售卖
        /// </summary>
        [XmlElement("can_sell")]
        public bool CanSell { get; set; }

        /// <summary>
        /// 客户端销售价（分）
        /// </summary>
        [XmlElement("price_cent")]
        public long PriceCent { get; set; }

        /// <summary>
        /// 商品sku信息
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// sku图片url
        /// </summary>
        [XmlElement("sku_pic_url")]
        public string SkuPicUrl { get; set; }

        /// <summary>
        /// sku标题
        /// </summary>
        [XmlElement("sku_title")]
        public string SkuTitle { get; set; }
    }
}
