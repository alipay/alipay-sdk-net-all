using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTourOrderQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportTourOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单价格
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付宝订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 业务发生的时间
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 总金额， 目前总金额 = 订单金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 凭证列表信息
        /// </summary>
        [XmlArray("voucher_list")]
        [XmlArrayItem("tour_voucher_info_queryopenapi_result")]
        public List<TourVoucherInfoQueryopenapiResult> VoucherList { get; set; }
    }
}
