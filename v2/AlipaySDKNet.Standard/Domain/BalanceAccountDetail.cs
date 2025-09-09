using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BalanceAccountDetail Data Structure.
    /// </summary>
    [Serializable]
    public class BalanceAccountDetail : AopObject
    {
        /// <summary>
        /// acs余额，单位：元
        /// </summary>
        [XmlElement("acs")]
        public string Acs { get; set; }

        /// <summary>
        /// bank余额，单位：元
        /// </summary>
        [XmlElement("bank")]
        public string Bank { get; set; }
    }
}
