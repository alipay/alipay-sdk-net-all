using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContinuousPlan Data Structure.
    /// </summary>
    [Serializable]
    public class ContinuousPlan : AopObject
    {
        /// <summary>
        /// 缴费完成时间 YYYY-MM-DD HH:MM:SS
        /// </summary>
        [XmlElement("continuous_finish_time")]
        public string ContinuousFinishTime { get; set; }

        /// <summary>
        /// 续期缴费结束时间 YYYY-MM-DD HH:MM:SS
        /// </summary>
        [XmlElement("continuous_grace_time")]
        public string ContinuousGraceTime { get; set; }

        /// <summary>
        /// 续期缴费开始时间 YYYY-MM-DD HH:MM:SS
        /// </summary>
        [XmlElement("continuous_start_time")]
        public string ContinuousStartTime { get; set; }

        /// <summary>
        /// 货币类型，枚举值
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [XmlElement("pay_trade_no")]
        public string PayTradeNo { get; set; }

        /// <summary>
        /// 期数
        /// </summary>
        [XmlElement("phase")]
        public string Phase { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        [XmlElement("plan_index")]
        public long PlanIndex { get; set; }

        /// <summary>
        /// 计划编号，缴费计划明细的唯一标识
        /// </summary>
        [XmlElement("plan_no")]
        public string PlanNo { get; set; }

        /// <summary>
        /// 续期保费 单位：币种标准单位，如：人民币-元（保留2位小数）
        /// </summary>
        [XmlElement("premium")]
        public string Premium { get; set; }

        /// <summary>
        /// 续期状态
        /// </summary>
        [XmlElement("renewal_status")]
        public string RenewalStatus { get; set; }
    }
}
