using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentOrderPrecreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentOrderPrecreateModel : AopObject
    {
        /// <summary>
        /// 优惠前置咨询组件返回的优惠活动咨询ID
        /// </summary>
        [XmlElement("activity_consult_id")]
        public string ActivityConsultId { get; set; }

        /// <summary>
        /// 订单收货地址
        /// </summary>
        [XmlElement("address_info")]
        public RentOrderReceiverAddressInfoDTO AddressInfo { get; set; }

        /// <summary>
        /// 用户身份信息，用于订单签约时身份校验
        /// </summary>
        [XmlElement("buyer_identity_info")]
        public RentBuyerIdentityInfo BuyerIdentityInfo { get; set; }

        /// <summary>
        /// 当用户进入预授权或代扣签约页面后，点击左上角的回退按钮，中断开通流程，跳转回商户的页面地址。支持scheme协议。不传该链接时，默认返回上一级页面
        /// </summary>
        [XmlElement("cancel_back_link")]
        public string CancelBackLink { get; set; }

        /// <summary>
        /// 默认退货寄回地址
        /// </summary>
        [XmlElement("default_receiving_address")]
        public RentOrderReceiverAddressInfoDTO DefaultReceivingAddress { get; set; }

        /// <summary>
        /// 订单履约信息
        /// </summary>
        [XmlElement("delivery_info")]
        public RentOrderDeliveryInfoDTO DeliveryInfo { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("item_infos")]
        [XmlArrayItem("rent_goods_detail_info_d_t_o")]
        public List<RentGoodsDetailInfoDTO> ItemInfos { get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 商户订单号，由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 端外订单来源
        /// </summary>
        [XmlElement("out_order_source")]
        public string OutOrderSource { get; set; }

        /// <summary>
        /// 订单金额信息
        /// </summary>
        [XmlElement("price_info")]
        public RentOrderPriceInfoDTO PriceInfo { get; set; }

        /// <summary>
        /// 租赁计划信息
        /// </summary>
        [XmlElement("rent_plan_info")]
        public RentPlanInfoDTO RentPlanInfo { get; set; }

        /// <summary>
        /// 租赁订单支付产品、信用产品签约信息。不传表示当前订单无需使用相应的能力
        /// </summary>
        [XmlElement("rent_sign_info")]
        public RentSignInfoDTO RentSignInfo { get; set; }

        /// <summary>
        /// 用户完成预授权或代扣签约后，不区分用户签约成功/失败，跳转回商家页面，该字段代表跳转回商家的页面地址。支持scheme协议。不传该链接时，默认返回上一级页面
        /// </summary>
        [XmlElement("return_back_link")]
        public string ReturnBackLink { get; set; }

        /// <summary>
        /// 二级商户信息。直付通模式和机构间连模式下必传，其它场景下不需要传入
        /// </summary>
        [XmlElement("sub_merchant")]
        public RentSubMerchantDTO SubMerchant { get; set; }

        /// <summary>
        /// 租赁订单标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 当商家收单appid与下单appid不一致时必传
        /// </summary>
        [XmlElement("trade_app_id")]
        public string TradeAppId { get; set; }
    }
}
