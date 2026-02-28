using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubsidyMoney Data Structure.
    /// </summary>
    [Serializable]
    public class SubsidyMoney : AopObject
    {
        /// <summary>
        /// 金额，单位分
        /// </summary>
        [XmlElement("cent")]
        public long Cent { get; set; }

        /// <summary>
        /// 货币
        /// </summary>
        [XmlElement("currency")]
        public SubsidyCurrency Currency { get; set; }
    }
}
