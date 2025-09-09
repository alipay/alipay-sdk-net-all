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
        /// 收费金额，单位：分
        /// </summary>
        [XmlElement("commission_cash")]
        public long CommissionCash { get; set; }

        /// <summary>
        /// 收费pid
        /// </summary>
        [XmlElement("commission_pid")]
        public string CommissionPid { get; set; }

        /// <summary>
        /// 收费方名称
        /// </summary>
        [XmlElement("commission_pid_name")]
        public string CommissionPidName { get; set; }

        /// <summary>
        /// 收费比例
        /// </summary>
        [XmlElement("commission_rate")]
        public string CommissionRate { get; set; }

        /// <summary>
        /// 费用退款金额，单位：分
        /// </summary>
        [XmlElement("commission_refund_cash")]
        public long CommissionRefundCash { get; set; }

        /// <summary>
        /// 费用退款时间
        /// </summary>
        [XmlElement("commission_refund_time")]
        public string CommissionRefundTime { get; set; }

        /// <summary>
        /// 收费日期
        /// </summary>
        [XmlElement("commission_time")]
        public string CommissionTime { get; set; }

        /// <summary>
        /// 收费类型
        /// </summary>
        [XmlElement("commission_type")]
        public string CommissionType { get; set; }
    }
}
