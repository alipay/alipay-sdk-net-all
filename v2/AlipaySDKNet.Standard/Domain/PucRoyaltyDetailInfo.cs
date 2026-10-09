using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PucRoyaltyDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PucRoyaltyDetailInfo : AopObject
    {
        /// <summary>
        /// 分账金额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 收入方账户
        /// </summary>
        [XmlElement("trans_in")]
        public string TransIn { get; set; }
    }
}
