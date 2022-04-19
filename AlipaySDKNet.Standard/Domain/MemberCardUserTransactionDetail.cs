using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberCardUserTransactionDetail Data Structure.
    /// </summary>
    [Serializable]
    public class MemberCardUserTransactionDetail : AopObject
    {
        /// <summary>
        /// 储值总金额，单位元。
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 储值优惠金额（权益金），单位元。如用户主动发起退款，优惠金额则表示退回商户账户金额。
        /// </summary>
        [XmlElement("benefit")]
        public string Benefit { get; set; }

        /// <summary>
        /// 交易发生时间，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 交易明细类型，枚举如下： RECHARGE=充值， PAYMENT=支付， REFUND=退款， RETURN=退卡
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 储值本金金额，单位元。如用户主动发起退款，本金金额则表示退回用户账号金额。
        /// </summary>
        [XmlElement("principal")]
        public string Principal { get; set; }

        /// <summary>
        /// 充值方案ID，detail_type=RECHARGE 时有值
        /// </summary>
        [XmlElement("promotion_plan_id")]
        public string PromotionPlanId { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
