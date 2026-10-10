using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditbenefitHuabeijinRefundResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditbenefitHuabeijinRefundResponse : AopResponse
    {
        /// <summary>
        /// 用户发奖活动调用成功之后给用户的单据id，用于后续的变更操作
        /// </summary>
        [XmlElement("activity_order_id")]
        public string ActivityOrderId { get; set; }

        /// <summary>
        /// 根据用户剩余花呗金数量结合本次退款的金额，尽力扣除的花呗金数量，用户花呗金数量不足的时候会小于应扣除花呗金数量，123花呗金代表123分
        /// </summary>
        [XmlElement("actual_deducted")]
        public long ActualDeducted { get; set; }

        /// <summary>
        /// 不同的业务码表示在花呗侧业务处理过程中的不同状态
        /// </summary>
        [XmlElement("hb_biz_code")]
        public string HbBizCode { get; set; }

        /// <summary>
        /// 商家操作流水id，原样返回
        /// </summary>
        [XmlElement("operation_seq_id")]
        public string OperationSeqId { get; set; }

        /// <summary>
        /// 输入中的外部业务单据，原样返回
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 用于表述根据本次退款金额和用户信息计算出的应该扣除的花呗金数量，123个花呗金代表123分
        /// </summary>
        [XmlElement("should_deducted")]
        public long ShouldDeducted { get; set; }
    }
}
