using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentRoyaltyInvestModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentRoyaltyInvestModifyModel : AopObject
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
        /// 交易组件的业务订单Id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 代表第几阶段的还款计划，要配合royalty_stage锁定第几期还款计划
        /// </summary>
        [XmlElement("royalty_period")]
        public long RoyaltyPeriod { get; set; }

        /// <summary>
        /// 分账金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("royalty_price")]
        public string RoyaltyPrice { get; set; }

        /// <summary>
        /// 代表某一个阶段的第几期的还款计划，要结合royalty_period进行锁定某一期计划
        /// </summary>
        [XmlElement("royalty_stage")]
        public long RoyaltyStage { get; set; }

        /// <summary>
        /// 分账计划对应资金类型
        /// </summary>
        [XmlElement("royalty_type")]
        public string RoyaltyType { get; set; }
    }
}
