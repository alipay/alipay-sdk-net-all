using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BillFeeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BillFeeInfo : AopObject
    {
        /// <summary>
        /// 抽佣金额，单位：分
        /// </summary>
        [XmlElement("commission_cash")]
        public long CommissionCash { get; set; }

        /// <summary>
        /// 抽佣pid
        /// </summary>
        [XmlElement("commission_pid")]
        public string CommissionPid { get; set; }

        /// <summary>
        /// 收费方名称
        /// </summary>
        [XmlElement("commission_pid_name")]
        public string CommissionPidName { get; set; }

        /// <summary>
        /// 退佣金额，单位：分
        /// </summary>
        [XmlElement("commission_refund_cash")]
        public long CommissionRefundCash { get; set; }

        /// <summary>
        /// 退佣时间
        /// </summary>
        [XmlElement("commission_refund_time")]
        public string CommissionRefundTime { get; set; }

        /// <summary>
        /// 抽佣日期
        /// </summary>
        [XmlElement("commission_time")]
        public string CommissionTime { get; set; }

        /// <summary>
        /// 抽佣类型
        /// </summary>
        [XmlElement("commission_type")]
        public string CommissionType { get; set; }
    }
}
