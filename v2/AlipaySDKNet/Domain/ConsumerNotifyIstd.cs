using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsumerNotifyIstd Data Structure.
    /// </summary>
    [Serializable]
    public class ConsumerNotifyIstd : AopObject
    {
        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("goods_count")]
        public long GoodsCount { get; set; }

        /// <summary>
        /// 商品缩略图url，支持格式：bmp、jpg、jpeg、png、gif
        /// </summary>
        [XmlElement("goods_img")]
        public string GoodsImg { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商家电话
        /// </summary>
        [XmlElement("merchant_mobile")]
        public string MerchantMobile { get; set; }

        /// <summary>
        /// 商家名称，tiny_app_id和merchant_name不能同时为空
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商家小程序appid
        /// </summary>
        [XmlElement("tiny_app_id")]
        public string TinyAppId { get; set; }

        /// <summary>
        /// 商家小程序的路径，建议为订单页面
        /// </summary>
        [XmlElement("tiny_app_url")]
        public string TinyAppUrl { get; set; }
    }
}
