using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OverdueDetail Data Structure.
    /// </summary>
    [Serializable]
    public class OverdueDetail : AopObject
    {
        /// <summary>
        /// 逾期的天数
        /// </summary>
        [XmlElement("overdue_day")]
        public long OverdueDay { get; set; }

        /// <summary>
        /// 逾期的备注和描述
        /// </summary>
        [XmlElement("overdue_desc")]
        public string OverdueDesc { get; set; }

        /// <summary>
        /// 逾期的金额。单位:元，精度:分。
        /// </summary>
        [XmlElement("overdue_fee")]
        public string OverdueFee { get; set; }

        /// <summary>
        /// 当前订单逾期的期数
        /// </summary>
        [XmlElement("overdue_period_num")]
        public long OverduePeriodNum { get; set; }

        /// <summary>
        /// 逾期时间 年-月-日 时:分:秒
        /// </summary>
        [XmlElement("overdue_time")]
        public string OverdueTime { get; set; }
    }
}
