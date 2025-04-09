using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentRoyaltyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentRoyaltyInfo : AopObject
    {
        /// <summary>
        /// 2088开头的16位纯数字，小程序场景下获取用户ID请参考：用户授权; 其它场景下获取用户ID请参考：网页授权获取用户信息; 其中buyer_id与buyer_open_id不能同时为空
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付宝用户唯一标识
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 资方appid
        /// </summary>
        [XmlElement("invest_app_id")]
        public string InvestAppId { get; set; }

        /// <summary>
        /// 订单分配给的资方的id
        /// </summary>
        [XmlElement("invest_pid")]
        public string InvestPid { get; set; }

        /// <summary>
        /// 交易组件的业务订单Id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 租赁分期计划，每一期分期计划详情
        /// </summary>
        [XmlArray("plan_list")]
        [XmlArrayItem("rent_plan")]
        public List<RentPlan> PlanList { get; set; }

        /// <summary>
        /// 分账信息列表，每一期的分账详情
        /// </summary>
        [XmlArray("royalty_list")]
        [XmlArrayItem("rent_royalty")]
        public List<RentRoyalty> RoyaltyList { get; set; }

        /// <summary>
        /// 该笔订单关联资方的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
