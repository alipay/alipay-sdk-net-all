using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderItemInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class OrderItemInfoVO : AopObject
    {
        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("item_cnt")]
        public long ItemCnt { get; set; }

        /// <summary>
        /// 支付宝平台侧商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品退款信息
        /// </summary>
        [XmlElement("item_refund_info")]
        public ItemRefundInfoVO ItemRefundInfo { get; set; }

        /// <summary>
        /// 商品标签列表
        /// </summary>
        [XmlElement("item_tags")]
        public ItemTagVO ItemTags { get; set; }

        /// <summary>
        /// 本地生活商品凭证信息列表
        /// </summary>
        [XmlArray("order_certificate_infos")]
        [XmlArrayItem("order_certificate_info_v_o")]
        public List<OrderCertificateInfoVO> OrderCertificateInfos { get; set; }

        /// <summary>
        /// 商户商品ID
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商户商品sku_id
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 商品单价，单位：元,精确到小数点后两位，可以跟上传商品接口的价格不一致
        /// </summary>
        [XmlElement("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 发货时效
        /// </summary>
        [XmlElement("shipping_time_limit")]
        public ShippingTimeLimitVO ShippingTimeLimit { get; set; }

        /// <summary>
        /// 支付宝侧商品skuid
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
