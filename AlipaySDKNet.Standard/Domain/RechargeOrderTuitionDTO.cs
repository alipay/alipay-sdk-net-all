using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RechargeOrderTuitionDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RechargeOrderTuitionDTO : AopObject
    {
        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 已完成的打款数
        /// </summary>
        [XmlElement("finished_periods")]
        public long FinishedPeriods { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 总的分期数
        /// </summary>
        [XmlElement("periods")]
        public long Periods { get; set; }

        /// <summary>
        /// 分期扣款任务列表，未付款状态，打款任务为空
        /// </summary>
        [XmlArray("plans")]
        [XmlArrayItem("instalment_plan_tuition_d_t_o")]
        public List<InstalmentPlanTuitionDTO> Plans { get; set; }

        /// <summary>
        /// 学费码分期付款扣款计划
        /// </summary>
        [XmlElement("recharge_config")]
        public RechargeConfigTuitionDTO RechargeConfig { get; set; }

        /// <summary>
        /// 退款类型 1, "全部退款" 2, "未到账资金退款"
        /// </summary>
        [XmlElement("refund_type")]
        public string RefundType { get; set; }

        /// <summary>
        /// 二级商户
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 订单状态 0, "待付款"  1, "打款流程中"  2, "打款完成"  3, "退款中"  4, "退款完成"  5, "冻结中"
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 充值总金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("user_display_name")]
        public string UserDisplayName { get; set; }

        /// <summary>
        /// 缴费用户的支付宝pid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
