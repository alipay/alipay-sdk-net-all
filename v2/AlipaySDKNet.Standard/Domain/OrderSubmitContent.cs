using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderSubmitContent Data Structure.
    /// </summary>
    [Serializable]
    public class OrderSubmitContent : AopObject
    {
        /// <summary>
        /// 订单收货人姓名，外层字段method_name为上报订单时必选
        /// </summary>
        [XmlElement("consignee_name")]
        public string ConsigneeName { get; set; }

        /// <summary>
        /// 收货人电话。外层字段method_name为上报订单时必选
        /// </summary>
        [XmlElement("consignee_phone")]
        public string ConsigneePhone { get; set; }

        /// <summary>
        /// 收货地址。外层字段method_name为上报订单时必选
        /// </summary>
        [XmlElement("delivery_address")]
        public string DeliveryAddress { get; set; }

        /// <summary>
        /// 订单优惠价格，单位：元
        /// </summary>
        [XmlElement("discount_fee")]
        public string DiscountFee { get; set; }

        /// <summary>
        /// 订单物流信息
        /// </summary>
        [XmlElement("logistics_info")]
        public string LogisticsInfo { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单跳转地址，小程序内部页面。外层字段method_name为上报订单时必选
        /// </summary>
        [XmlElement("order_url")]
        public string OrderUrl { get; set; }

        /// <summary>
        /// 订单原价格，单位：元
        /// </summary>
        [XmlElement("origin_fee")]
        public string OriginFee { get; set; }

        /// <summary>
        /// 外部订单号 outOrderId唯一对应一笔订单，相同的订单需传入相同的outOrderId
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 支付日期，外层字段method_name为上报订单时必选
        /// </summary>
        [XmlElement("pay_date")]
        public string PayDate { get; set; }

        /// <summary>
        /// 订单支付价格(=整单原价-整单优惠金额+运费)，单位为【元】。外层字段method_name为上报订单时必选
        /// </summary>
        [XmlElement("pay_fee")]
        public string PayFee { get; set; }

        /// <summary>
        /// 店铺名称。外层字段method_name为上报订单时必选
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺url跳转地址。外层字段method_name为上报订单时必选
        /// </summary>
        [XmlElement("shop_url")]
        public string ShopUrl { get; set; }

        /// <summary>
        /// 子订单信息列表。外层参数method_name为上报订单时必选
        /// </summary>
        [XmlArray("unimall_sub_orders")]
        [XmlArrayItem("sub_order_content")]
        public List<SubOrderContent> UnimallSubOrders { get; set; }
    }
}
