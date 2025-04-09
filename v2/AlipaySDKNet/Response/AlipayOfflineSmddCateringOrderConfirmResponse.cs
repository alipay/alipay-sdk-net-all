using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineSmddCateringOrderConfirmResponse.
    /// </summary>
    public class AlipayOfflineSmddCateringOrderConfirmResponse : AopResponse
    {
        /// <summary>
        /// 活动列表，商品促销活动
        /// </summary>
        [XmlArray("activity_list")]
        [XmlArrayItem("activity_bean")]
        public List<ActivityBean> ActivityList { get; set; }

        /// <summary>
        /// 运费 单位元
        /// </summary>
        [XmlElement("delivery_fee")]
        public string DeliveryFee { get; set; }

        /// <summary>
        /// 优惠提示文案信息
        /// </summary>
        [XmlElement("discount_notice_text")]
        public string DiscountNoticeText { get; set; }

        /// <summary>
        /// 优惠金额 单位元
        /// </summary>
        [XmlElement("discounted_price")]
        public string DiscountedPrice { get; set; }

        /// <summary>
        /// 该价格是商品总价-满减优惠的，不包含外送费，打包费，单位元
        /// </summary>
        [XmlElement("item_total_price")]
        public string ItemTotalPrice { get; set; }

        /// <summary>
        /// 购物车原价 单位元
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 打包费 单位元
        /// </summary>
        [XmlElement("package_fee")]
        public string PackageFee { get; set; }

        /// <summary>
        /// 付款价 单位元
        /// </summary>
        [XmlElement("payment_price")]
        public string PaymentPrice { get; set; }

        /// <summary>
        /// sku列表
        /// </summary>
        [XmlArray("sku_list")]
        [XmlArrayItem("sku_bean")]
        public List<SkuBean> SkuList { get; set; }

        /// <summary>
        /// 商品总数 单位：个/份
        /// </summary>
        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
