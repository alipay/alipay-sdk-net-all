using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentOrderCreateModel : AopObject
    {
        /// <summary>
        /// 订单收货地址
        /// </summary>
        [XmlElement("address_info")]
        public RentOrderReceiverAddressInfoDTO AddressInfo { get; set; }

        /// <summary>
        /// 买家支付宝用户id，小程序场景下获取用户ID请参考：用户授权; 其它场景下获取用户ID请参考：网页授权获取用户信息。
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付宝用户唯一标识
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 租赁购买创单信息
        /// </summary>
        [XmlElement("buyout_info")]
        public RentBuyoutInfoDTO BuyoutInfo { get; set; }

        /// <summary>
        /// 买断分期号。租转售模式，阶梯买断场景下必传
        /// </summary>
        [XmlElement("buyout_installment_no")]
        public long BuyoutInstallmentNo { get; set; }

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
        /// 商品详细信息。当前只支持单个商品。
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
        /// 订单类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 商户订单号，由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 原始租赁订单号。订单类型为续租、租转售时必传
        /// </summary>
        [XmlElement("parent_order_id")]
        public string ParentOrderId { get; set; }

        /// <summary>
        /// 租赁订单页面地址信息
        /// </summary>
        [XmlElement("path_info")]
        public RentPathInfoDTO PathInfo { get; set; }

        /// <summary>
        /// 订单金额信息
        /// </summary>
        [XmlElement("price_info")]
        public RentOrderPriceInfoDTO PriceInfo { get; set; }

        /// <summary>
        /// 租赁续租创单信息
        /// </summary>
        [XmlElement("relet_info")]
        public RentReletInfoDTO ReletInfo { get; set; }

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
        /// 服务商模式。签约资商通直付通平台商分账产品后，下单时传入平台模式 PLATFORM，smid必传；此模式下支持服务商派单模式
        /// </summary>
        [XmlElement("service_provider_model")]
        public string ServiceProviderModel { get; set; }

        /// <summary>
        /// 追踪ID，租赁交易组件下单必传，会影响主播归因、分享员归因等；通过调用<a href="https://opendocs.alipay.com/mini/512c3ce1_my.checkBeforeAddOrder?pathHash=4b9d23c5" target="_blank">my.checkBeforeAddOrder</a>接口返回
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 二级商户信息。直付通模式和机构间连模式下必传，其它场景下不需要传入
        /// </summary>
        [XmlElement("sub_merchant")]
        public RentSubMerchantDTO SubMerchant { get; set; }

        /// <summary>
        /// 租赁订单标题，用于支付宝小程序订单中心、芝麻租赁频道中对用户展示
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 当商家收单appid与下单appid不一致时必传
        /// </summary>
        [XmlElement("trade_app_id")]
        public string TradeAppId { get; set; }

        /// <summary>
        /// 资商通产品信息
        /// </summary>
        [XmlElement("zst_info")]
        public RentZstInfoDTO ZstInfo { get; set; }
    }
}
