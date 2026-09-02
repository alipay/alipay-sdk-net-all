using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditbenefitHuabeijinCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiPcreditbenefitHuabeijinCancelModel : AopObject
    {
        /// <summary>
        /// hbmt_53434343434商户活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动流水单据
        /// </summary>
        [XmlElement("activity_order_id")]
        public string ActivityOrderId { get; set; }

        /// <summary>
        /// 任意字符串，如aaaa，但是会提供几个原因选择做映射
        /// </summary>
        [XmlElement("cancel_reason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        [XmlElement("cancel_time")]
        public string CancelTime { get; set; }

        /// <summary>
        /// 行业场景标识,依赖双方约定
        /// </summary>
        [XmlElement("industry_value")]
        public string IndustryValue { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 操作流水，本次操作唯一
        /// </summary>
        [XmlElement("operation_seq_id")]
        public string OperationSeqId { get; set; }

        /// <summary>
        /// 业务订单号，业务活动级别的唯一订单
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝订单需要下支付单
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
