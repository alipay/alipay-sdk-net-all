using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProfitSharingRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ProfitSharingRequest : AopObject
    {
        /// <summary>
        /// 参与分账的目标支付宝账号 2088**********34
        /// </summary>
        [XmlElement("alloc_account")]
        public string AllocAccount { get; set; }

        /// <summary>
        /// 分账到目标支付宝账号的金额，单位元
        /// </summary>
        [XmlElement("alloc_amount")]
        public string AllocAmount { get; set; }
    }
}
