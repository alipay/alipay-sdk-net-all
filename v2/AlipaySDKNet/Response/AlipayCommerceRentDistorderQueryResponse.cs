using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentDistorderQueryResponse.
    /// </summary>
    public class AlipayCommerceRentDistorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否租三免一订单
        /// </summary>
        [XmlElement("act_tag")]
        public string ActTag { get; set; }

        /// <summary>
        /// 分销订单号
        /// </summary>
        [XmlElement("biz_order_id")]
        public string BizOrderId { get; set; }

        /// <summary>
        /// 买家收货地址
        /// </summary>
        [XmlElement("buyer_address")]
        public DistributionMerchantAddressDTO BuyerAddress { get; set; }

        /// <summary>
        /// 买家昵称
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 渠道买家ID
        /// </summary>
        [XmlElement("channel_buyer_id")]
        public string ChannelBuyerId { get; set; }

        /// <summary>
        /// 渠道订单号
        /// </summary>
        [XmlElement("channel_order_id")]
        public string ChannelOrderId { get; set; }

        /// <summary>
        /// 关单原因
        /// </summary>
        [XmlElement("close_reason")]
        public string CloseReason { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 实际免押金额，单位为元
        /// </summary>
        [XmlElement("credit_deposit_amount")]
        public string CreditDepositAmount { get; set; }

        /// <summary>
        /// 芝麻免押状态 INIT(初始)、AUTHORIZED(已授权)、FINISH(完成)、CLOSED(关闭); 仅INIT状态可改价。
        /// </summary>
        [XmlElement("credit_deposit_status")]
        public string CreditDepositStatus { get; set; }

        /// <summary>
        /// 分销渠道
        /// </summary>
        [XmlElement("distribution_channel")]
        public string DistributionChannel { get; set; }

        /// <summary>
        /// 订单完结时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 运费,单位为元
        /// </summary>
        [XmlElement("freight")]
        public string Freight { get; set; }

        /// <summary>
        /// 已支付押金金额，单位为元
        /// </summary>
        [XmlElement("fund_deposit_amount")]
        public string FundDepositAmount { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("dist_item_d_t_o")]
        public List<DistItemDTO> Items { get; set; }

        /// <summary>
        /// 发货物流信息
        /// </summary>
        [XmlElement("logistics_info")]
        public DistLogisticsInfoDTO LogisticsInfo { get; set; }

        /// <summary>
        /// 首期租金支付时间 
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 租赁计划信息
        /// </summary>
        [XmlElement("rent_plan_info")]
        public DistRentPlanInfoDTO RentPlanInfo { get; set; }

        /// <summary>
        /// 归还地址
        /// </summary>
        [XmlElement("return_address")]
        public DistributionMerchantAddressDTO ReturnAddress { get; set; }

        /// <summary>
        /// 发货时间
        /// </summary>
        [XmlElement("ship_time")]
        public string ShipTime { get; set; }

        /// <summary>
        /// 分销订单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
