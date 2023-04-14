using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIndustryOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIndustryOrderSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝userid（用户在支付宝平台的2088开头16位id）
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 行业信息  数据格式详情联系解决方案同学
        /// </summary>
        [XmlElement("industry_info")]
        public string IndustryInfo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 支付宝用户的openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单详情链接 链接是商户自己的小程序的
        /// </summary>
        [XmlElement("order_detail_url")]
        public string OrderDetailUrl { get; set; }

        /// <summary>
        /// 订单扩展字段，示例展示场景：key：scene_type，value：NOTICE_TOUCH；key：cup_type，value:BRING_CUP
        /// </summary>
        [XmlElement("order_extra_info")]
        public ExtraInfo OrderExtraInfo { get; set; }

        /// <summary>
        /// 订单修改时间(订单更新时需有变动)
        /// </summary>
        [XmlElement("order_modify_time")]
        public string OrderModifyTime { get; set; }

        /// <summary>
        /// 订单类型，枚举支持 ALIPAY_APPLETS：支付宝小程序产生的订单 ALIPAY_POS：收银POS产生的支付宝订单  ALIPAY_INDUSTRY：支付宝行业小程序
        /// </summary>
        [XmlElement("order_source")]
        public string OrderSource { get; set; }

        /// <summary>
        /// 交易支付金额
        /// </summary>
        [XmlElement("payment_amount")]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// 商户订单同步记录id
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 服务标识
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务类型   具体值联系解决方案同学
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 订单状态枚举  数据格式详情联系解决方案同学
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子服务类型
        /// </summary>
        [XmlElement("sub_service_type")]
        public string SubServiceType { get; set; }
    }
}
