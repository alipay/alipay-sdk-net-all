using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsumerLoanBillAggInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ConsumerLoanBillAggInfo : AopObject
    {
        /// <summary>
        /// 当前待还总金额，单位为分，1000代表10.00元
        /// </summary>
        [XmlElement("current_repay_amount")]
        public long CurrentRepayAmount { get; set; }

        /// <summary>
        /// 出账日期，若无出账日可不填
        /// </summary>
        [XmlElement("expanditure_publish_date")]
        public string ExpanditurePublishDate { get; set; }

        /// <summary>
        /// 到期天数，单位为天
        /// </summary>
        [XmlElement("expire_days")]
        public long ExpireDays { get; set; }

        /// <summary>
        /// 剩余待还总金额，单位为分，1000代表10.00元
        /// </summary>
        [XmlElement("last_total_principal_amount")]
        public long LastTotalPrincipalAmount { get; set; }

        /// <summary>
        /// 下期待还金额，单位为分，1000代表10.00元
        /// </summary>
        [XmlElement("next_repay_amount")]
        public long NextRepayAmount { get; set; }

        /// <summary>
        /// 下期还款时间
        /// </summary>
        [XmlElement("next_repay_date")]
        public string NextRepayDate { get; set; }

        /// <summary>
        /// 还款日期
        /// </summary>
        [XmlElement("repay_date")]
        public string RepayDate { get; set; }

        /// <summary>
        /// 是否特殊账务状态，当用户标识为延期、展期、债务重组、联贷转自营时，用户点击“查看”，直接跳转到三方商户承接页
        /// </summary>
        [XmlElement("special_account")]
        public bool SpecialAccount { get; set; }

        /// <summary>
        /// 账单聚合状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
