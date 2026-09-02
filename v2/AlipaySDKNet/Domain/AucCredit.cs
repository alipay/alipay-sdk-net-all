using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AucCredit Data Structure.
    /// </summary>
    [Serializable]
    public class AucCredit : AopObject
    {
        /// <summary>
        /// 客户授信金额，单位分
        /// </summary>
        [XmlElement("credit_amt")]
        public long CreditAmt { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("credit_pricing_list")]
        [XmlArrayItem("auc_credit_pricing")]
        public List<AucCreditPricing> CreditPricingList { get; set; }

        /// <summary>
        /// 授信过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }
    }
}
