using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CounterpartyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CounterpartyInfo : AopObject
    {
        /// <summary>
        /// 与对手方近6个月资金往来金额等级
        /// </summary>
        [XmlElement("counter_amount_range")]
        public string CounterAmountRange { get; set; }

        /// <summary>
        /// 与对手方近6个月资金往来频次等级
        /// </summary>
        [XmlElement("counter_count_range")]
        public string CounterCountRange { get; set; }

        /// <summary>
        /// 对手方企业名称
        /// </summary>
        [XmlElement("counter_org_name")]
        public string CounterOrgName { get; set; }

        /// <summary>
        /// 对手方注册号
        /// </summary>
        [XmlElement("counter_reg_no")]
        public string CounterRegNo { get; set; }

        /// <summary>
        /// 对手方统一社会信用代码
        /// </summary>
        [XmlElement("counter_uscc")]
        public string CounterUscc { get; set; }

        /// <summary>
        /// 转账方向
        /// </summary>
        [XmlElement("transfer_direction")]
        public string TransferDirection { get; set; }
    }
}
