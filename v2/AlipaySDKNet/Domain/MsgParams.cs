using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MsgParams Data Structure.
    /// </summary>
    [Serializable]
    public class MsgParams : AopObject
    {
        /// <summary>
        /// 账单金额
        /// </summary>
        [XmlElement("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 到期天数
        /// </summary>
        [XmlElement("expire_days")]
        public string ExpireDays { get; set; }

        /// <summary>
        /// 还款时间
        /// </summary>
        [XmlElement("repay_date")]
        public string RepayDate { get; set; }
    }
}
