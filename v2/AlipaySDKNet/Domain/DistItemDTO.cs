using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DistItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DistItemDTO : AopObject
    {
        /// <summary>
        /// 渠道商品ID
        /// </summary>
        [XmlElement("channel_item_id")]
        public string ChannelItemId { get; set; }

        /// <summary>
        /// 渠道商品图片
        /// </summary>
        [XmlElement("channel_item_pic_url")]
        public string ChannelItemPicUrl { get; set; }

        /// <summary>
        /// 渠道商品价格，单位元
        /// </summary>
        [XmlElement("channel_item_price")]
        public string ChannelItemPrice { get; set; }

        /// <summary>
        /// 渠道商品标题
        /// </summary>
        [XmlElement("channel_item_title")]
        public string ChannelItemTitle { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("item_cnt")]
        public long ItemCnt { get; set; }

        /// <summary>
        /// 商品库itemId
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商户侧商品Id
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商户侧SkuId
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 商品库skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
