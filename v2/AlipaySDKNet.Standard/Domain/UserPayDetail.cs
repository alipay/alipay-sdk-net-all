using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserPayDetail Data Structure.
    /// </summary>
    [Serializable]
    public class UserPayDetail : AopObject
    {
        /// <summary>
        /// 发款账号
        /// </summary>
        [XmlElement("pay_account")]
        public string PayAccount { get; set; }

        /// <summary>
        /// 发款完成时间
        /// </summary>
        [XmlElement("pay_finish_time")]
        public string PayFinishTime { get; set; }

        /// <summary>
        /// 发款流水号
        /// </summary>
        [XmlElement("pay_fund_order_id")]
        public string PayFundOrderId { get; set; }

        /// <summary>
        /// 0：未发薪 1：发薪完成 2：发薪失败
        /// </summary>
        [XmlElement("salary_status")]
        public long SalaryStatus { get; set; }

        /// <summary>
        /// 用户账单编号，全局唯一。计税时候传的user_bill_no字段
        /// </summary>
        [XmlElement("user_bill_no")]
        public string UserBillNo { get; set; }
    }
}
