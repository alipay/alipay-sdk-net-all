using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditRateNoAuth Data Structure.
    /// </summary>
    [Serializable]
    public class CreditRateNoAuth : AopObject
    {
        /// <summary>
        /// 信用等级名称
        /// </summary>
        [XmlElement("cr_rank_title")]
        public string CrRankTitle { get; set; }
    }
}
