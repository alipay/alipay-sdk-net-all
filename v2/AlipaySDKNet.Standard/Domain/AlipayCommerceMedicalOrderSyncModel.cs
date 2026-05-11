using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalOrderSyncModel : AopObject
    {
        /// <summary>
        /// 关联支付宝交易号
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// UID，可能有两种，根据buyer_id_type判断类型： 1、淘宝闪购uid，返回淘宝闪购uid； 2、支付宝uid，以2088开头；
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 用户uid类型
        /// </summary>
        [XmlElement("buyer_id_type")]
        public string BuyerIdType { get; set; }

        /// <summary>
        /// 渠道订单ID
        /// </summary>
        [XmlElement("channel_order_no")]
        public string ChannelOrderNo { get; set; }

        /// <summary>
        /// 渠道类型
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 配送费，单位为【分】
        /// </summary>
        [XmlElement("delivery_fee")]
        public long DeliveryFee { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("third_party_ext_info")]
        public List<ThirdPartyExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("item_third_party_info")]
        public List<ItemThirdPartyInfo> ItemList { get; set; }

        /// <summary>
        /// 用户医保支付金额，单位为【分】
        /// </summary>
        [XmlElement("medical_insurance_amount")]
        public long MedicalInsuranceAmount { get; set; }

        /// <summary>
        /// 订单场景
        /// </summary>
        [XmlElement("order_scene")]
        public string OrderScene { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单时间信息
        /// </summary>
        [XmlElement("order_time_info")]
        public OrderTimestampInfo OrderTimeInfo { get; set; }

        /// <summary>
        /// 打包费，单位为【分】
        /// </summary>
        [XmlElement("packing_fee")]
        public long PackingFee { get; set; }

        /// <summary>
        /// 用户实付金额 ：用户最终结算时需要支付金额，单位为【分】
        /// </summary>
        [XmlElement("pay_amount")]
        public long PayAmount { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("reverse_order_list")]
        [XmlArrayItem("reverse_order_info")]
        public List<ReverseOrderInfo> ReverseOrderList { get; set; }

        /// <summary>
        /// 用户自费金额，单位为【分】
        /// </summary>
        [XmlElement("self_pay_amount")]
        public long SelfPayAmount { get; set; }

        /// <summary>
        /// 三方门店信息
        /// </summary>
        [XmlElement("shop_info")]
        public ShopThirdPartyInfo ShopInfo { get; set; }

        /// <summary>
        /// 订单总金额：某笔交易订单优惠前的总金额，单位为【分】
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
