using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BankSettleDetail Data Structure.
    /// </summary>
    [Serializable]
    public class BankSettleDetail : AopObject
    {
        /// <summary>
        /// 分账方
        /// </summary>
        [XmlElement("royalty_type")]
        public string RoyaltyType { get; set; }

        /// <summary>
        /// 分账金额，单位元
        /// </summary>
        [XmlElement("settle_amt")]
        public string SettleAmt { get; set; }
    }
}
