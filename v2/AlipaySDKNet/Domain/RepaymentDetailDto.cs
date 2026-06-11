using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RepaymentDetailDto Data Structure.
    /// </summary>
    [Serializable]
    public class RepaymentDetailDto : AopObject
    {
        /// <summary>
        /// 交易订单号
        /// </summary>
        [XmlElement("biz_order_id")]
        public string BizOrderId { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 还款期数
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 还款利息,单位:元
        /// </summary>
        [XmlElement("repayment_interest_price")]
        public string RepaymentInterestPrice { get; set; }

        /// <summary>
        /// 还款本金,单位:元
        /// </summary>
        [XmlElement("repayment_principal_price")]
        public string RepaymentPrincipalPrice { get; set; }

        /// <summary>
        /// 实际还款日
        /// </summary>
        [XmlElement("repayment_time")]
        public string RepaymentTime { get; set; }

        /// <summary>
        /// 还款总金额，单位：元
        /// </summary>
        [XmlElement("repayment_total_price")]
        public string RepaymentTotalPrice { get; set; }

        /// <summary>
        /// 还款阶段
        /// </summary>
        [XmlElement("stage")]
        public string Stage { get; set; }

        /// <summary>
        /// 租赁类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
