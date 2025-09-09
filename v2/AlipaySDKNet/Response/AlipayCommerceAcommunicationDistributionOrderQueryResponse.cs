using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationDistributionOrderQueryResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationDistributionOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// 该订单已产生的业务消息
        /// </summary>
        [XmlArray("biz_order_message_list")]
        [XmlArrayItem("biz_order_message")]
        public List<BizOrderMessage> BizOrderMessageList { get; set; }

        /// <summary>
        /// 活动id,海豚发奖相关
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 机构订单号
        /// </summary>
        [XmlElement("inst_order_id")]
        public string InstOrderId { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单成功
        /// </summary>
        [XmlElement("order_status_code")]
        public string OrderStatusCode { get; set; }

        /// <summary>
        /// 订单状态详情描述
        /// </summary>
        [XmlElement("order_status_desc")]
        public string OrderStatusDesc { get; set; }

        /// <summary>
        /// 外部奖品id，如果为券，则为券id
        /// </summary>
        [XmlElement("out_prize_id")]
        public string OutPrizeId { get; set; }

        /// <summary>
        /// 奖品id,海豚发券相关
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 运营商侧的订单号，当下游运营商系统存在自己内部订单号的情况下这里为运营商订单号。否则这里为空。仅对部分服务商开放
        /// </summary>
        [XmlElement("supplier_order_no")]
        public string SupplierOrderNo { get; set; }
    }
}
