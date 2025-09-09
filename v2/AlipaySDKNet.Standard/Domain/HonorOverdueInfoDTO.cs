using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HonorOverdueInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class HonorOverdueInfoDTO : AopObject
    {
        /// <summary>
        /// 逾期总额，单位：分
        /// </summary>
        [XmlElement("overdue_amount")]
        public string OverdueAmount { get; set; }

        /// <summary>
        /// 逾期天数，多笔分期/借据逾期 最大逾期天数
        /// </summary>
        [XmlElement("overdue_days")]
        public long OverdueDays { get; set; }

        /// <summary>
        /// 逾期订单数
        /// </summary>
        [XmlElement("overdue_order")]
        public long OverdueOrder { get; set; }

        /// <summary>
        /// 逾期罚息，单位：分，本金罚息+利息罚息
        /// </summary>
        [XmlElement("overdue_penalty")]
        public string OverduePenalty { get; set; }
    }
}
