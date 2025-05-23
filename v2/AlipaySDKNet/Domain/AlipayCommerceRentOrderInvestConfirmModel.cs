using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentOrderInvestConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentOrderInvestConfirmModel : AopObject
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
        /// 如果是确认放款款那么这个confirm_out_order_id就是放款借据ID 如果是确认还款那么这个confirm_out_order_id就是还款借据ID
        /// </summary>
        [XmlElement("confirm_out_order_id")]
        public string ConfirmOutOrderId { get; set; }

        /// <summary>
        /// 资方放款失败、还款失败、结清失败的原因
        /// </summary>
        [XmlElement("confirm_reason")]
        public string ConfirmReason { get; set; }

        /// <summary>
        /// 资方确认结果
        /// </summary>
        [XmlElement("confirm_result")]
        public string ConfirmResult { get; set; }

        /// <summary>
        /// 放款、还款、结清确认时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("confirm_time")]
        public string ConfirmTime { get; set; }

        /// <summary>
        /// 订单、分账、放款、还款、结清确认类型
        /// </summary>
        [XmlElement("confirm_type")]
        public string ConfirmType { get; set; }

        /// <summary>
        /// 交易组件的业务订单Id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 还款利息，单位：元
        /// </summary>
        [XmlElement("repayment_interest_price")]
        public string RepaymentInterestPrice { get; set; }

        /// <summary>
        /// 还款本金，单位：元
        /// </summary>
        [XmlElement("repayment_principal_price")]
        public string RepaymentPrincipalPrice { get; set; }

        /// <summary>
        /// 还款总金额,单位：元
        /// </summary>
        [XmlElement("repayment_total_price")]
        public string RepaymentTotalPrice { get; set; }

        /// <summary>
        /// 代表第几阶段的还款计划，要配合royalty_stage锁定第几期还款计划，royalty_type=BUYOUT的情况下，可不填
        /// </summary>
        [XmlElement("royalty_period")]
        public long RoyaltyPeriod { get; set; }

        /// <summary>
        /// 代表某一个阶段的第几期的还款计划，要结合royalty_period进行锁定某一期计划，royalty_type=BUYOUT的情况下，可不填
        /// </summary>
        [XmlElement("royalty_stage")]
        public long RoyaltyStage { get; set; }

        /// <summary>
        /// 分账计划类型，目前只支持RENT、DEPOSIT、BUYOUT三种类型
        /// </summary>
        [XmlElement("royalty_type")]
        public string RoyaltyType { get; set; }
    }
}
