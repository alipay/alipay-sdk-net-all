using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayVoyagerIndustryOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayVoyagerIndustryOrderSyncModel : AopObject
    {
        /// <summary>
        /// 买家信息
        /// </summary>
        [XmlElement("buyer_info")]
        public Buyer BuyerInfo { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        [XmlElement("discount_amount")]
        public AmountDTO DiscountAmount { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("string")]
        public List<string> ExtInfo { get; set; }

        /// <summary>
        /// 行业编码。由voyager分配给各个小程序透传过来。
        /// </summary>
        [XmlElement("industry_code")]
        public string IndustryCode { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlArray("item_order_list")]
        [XmlArrayItem("travel_item_info")]
        public List<TravelItemInfo> ItemOrderList { get; set; }

        /// <summary>
        /// 物流信息
        /// </summary>
        [XmlArray("logistics_info_list")]
        [XmlArrayItem("traveler_logistics_info")]
        public List<TravelerLogisticsInfo> LogisticsInfoList { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识，可传user_id，不传open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("order_amount")]
        public AmountDTO OrderAmount { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单修改时间
        /// </summary>
        [XmlElement("order_modified_time")]
        public string OrderModifiedTime { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [XmlElement("order_pay_time")]
        public string OrderPayTime { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        [XmlElement("pay_amount")]
        public AmountDTO PayAmount { get; set; }

        /// <summary>
        /// 支付宝给商户的支付订单号
        /// </summary>
        [XmlElement("payment_no")]
        public string PaymentNo { get; set; }

        /// <summary>
        /// 来源APP
        /// </summary>
        [XmlElement("source_app")]
        public string SourceApp { get; set; }

        /// <summary>
        /// 支付宝用户的userId，可传openid，不传userid。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
