using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditbenefitHuabeijinModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiPcreditbenefitHuabeijinModifyModel : AopObject
    {
        /// <summary>
        /// hbmt_53434343434花呗商户活动
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动单据流水
        /// </summary>
        [XmlElement("activity_order_id")]
        public string ActivityOrderId { get; set; }

        /// <summary>
        /// 123为1.23元单位为分
        /// </summary>
        [XmlElement("actual_amount")]
        public long ActualAmount { get; set; }

        /// <summary>
        /// change_reason
        /// </summary>
        [XmlElement("change_reason")]
        public string ChangeReason { get; set; }

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
        /// operation_seq_id表示商家侧操作流水，表示本次操作是唯一性的操作
        /// </summary>
        [XmlElement("operation_seq_id")]
        public string OperationSeqId { get; set; }

        /// <summary>
        /// 外部订单号，同活动下要唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝订单号
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
