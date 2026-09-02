using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentPayInfo : AopObject
    {
        /// <summary>
        /// 租期结束日期
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 支付金额,单位:元
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付日期
        /// </summary>
        [XmlElement("pay_date")]
        public string PayDate { get; set; }

        /// <summary>
        /// 支付期数
        /// </summary>
        [XmlElement("pay_periods")]
        public string PayPeriods { get; set; }

        /// <summary>
        /// 租期开始日期
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
