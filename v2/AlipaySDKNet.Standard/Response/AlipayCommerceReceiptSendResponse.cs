using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceReceiptSendResponse.
    /// </summary>
    public class AlipayCommerceReceiptSendResponse : AopResponse
    {
        /// <summary>
        /// 商品列表中有对应的环保类型时，需要返回
        /// </summary>
        [XmlArray("order_goods_list")]
        [XmlArrayItem("environment_info")]
        public List<EnvironmentInfo> OrderGoodsList { get; set; }

        /// <summary>
        /// 订单回传存在订单维度错误信息时，需要返回
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("green_order_receipt_send_info")]
        public List<GreenOrderReceiptSendInfo> OrderList { get; set; }
    }
}
