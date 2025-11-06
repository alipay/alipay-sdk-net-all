using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsPayEntryDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsPayEntryDTO : AopObject
    {
        /// <summary>
        /// 金额，单位分
        /// </summary>
        [XmlElement("fee")]
        public long Fee { get; set; }

        /// <summary>
        /// 支出户，根据账户类型传
        /// </summary>
        [XmlElement("in_account_no")]
        public string InAccountNo { get; set; }

        /// <summary>
        /// 收入户账户类型（ALIPAY、BANK、OTHER）
        /// </summary>
        [XmlElement("in_account_type")]
        public string InAccountType { get; set; }

        /// <summary>
        /// 收入户，根据账户类型传
        /// </summary>
        [XmlElement("out_account_no")]
        public string OutAccountNo { get; set; }

        /// <summary>
        /// 支出户账户类型（ALIPAY、BANK、OTHER）
        /// </summary>
        [XmlElement("out_account_type")]
        public string OutAccountType { get; set; }

        /// <summary>
        /// 支付流水
        /// </summary>
        [XmlElement("pay_flow_id")]
        public string PayFlowId { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }
    }
}
