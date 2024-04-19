using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotmbsOrderprintreceiptQueryResponse.
    /// </summary>
    public class AlipayOpenIotmbsOrderprintreceiptQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付渠道
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 账单支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 这笔订单的收款金额
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 真实付款金额，金额单位：元
        /// </summary>
        [XmlElement("real_price")]
        public string RealPrice { get; set; }

        /// <summary>
        /// 订单的商品列表
        /// </summary>
        [XmlArray("sku_list")]
        [XmlArrayItem("light_pos_order_sku")]
        public List<LightPosOrderSku> SkuList { get; set; }

        /// <summary>
        /// 订单的状态，标识是否支付成功
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
