using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentInfo : AopObject
    {
        /// <summary>
        /// 交易组件的订单Id
        /// </summary>
        [XmlElement("biz_order_id")]
        public string BizOrderId { get; set; }

        /// <summary>
        /// 买家Id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付宝用户唯一标识
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 订单到期买断金，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("buyout_price")]
        public string BuyoutPrice { get; set; }

        /// <summary>
        /// 提前结清,true表示提前结清
        /// </summary>
        [XmlElement("early_settle")]
        public bool EarlySettle { get; set; }

        /// <summary>
        /// 提前结清金额，单位：元
        /// </summary>
        [XmlElement("early_settle_price")]
        public string EarlySettlePrice { get; set; }

        /// <summary>
        /// 提前结清时间，具体到天
        /// </summary>
        [XmlElement("early_settle_time")]
        public string EarlySettleTime { get; set; }

        /// <summary>
        /// 租赁订单的结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 资方appid
        /// </summary>
        [XmlElement("invest_app_id")]
        public string InvestAppId { get; set; }

        /// <summary>
        /// 资方pid
        /// </summary>
        [XmlElement("invest_pid")]
        public string InvestPid { get; set; }

        /// <summary>
        /// 订单信息，包含订单信息、商品信息、收货人信息以及价格信息
        /// </summary>
        [XmlElement("order_info")]
        public SimpleOrderInfo OrderInfo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 租赁分期计划
        /// </summary>
        [XmlArray("plan_list")]
        [XmlArrayItem("rent_plan")]
        public List<RentPlan> PlanList { get; set; }

        /// <summary>
        /// 租赁订单价格，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("price_info")]
        public string PriceInfo { get; set; }

        /// <summary>
        /// 履约明细信息
        /// </summary>
        [XmlArray("rent_detail_list")]
        [XmlArrayItem("rent_detail")]
        public List<RentDetail> RentDetailList { get; set; }

        /// <summary>
        /// 租赁订单id
        /// </summary>
        [XmlElement("rent_id")]
        public string RentId { get; set; }

        /// <summary>
        /// 租赁单状态
        /// </summary>
        [XmlElement("rent_status")]
        public string RentStatus { get; set; }

        /// <summary>
        /// 分账计划详情
        /// </summary>
        [XmlArray("royalty_list")]
        [XmlArrayItem("rent_royalty")]
        public List<RentRoyalty> RoyaltyList { get; set; }

        /// <summary>
        /// 租赁商用户Id
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 二级商户id
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 租赁订单的开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
