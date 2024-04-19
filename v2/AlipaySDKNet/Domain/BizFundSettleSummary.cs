using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizFundSettleSummary Data Structure.
    /// </summary>
    [Serializable]
    public class BizFundSettleSummary : AopObject
    {
        /// <summary>
        /// 整单手续费
        /// </summary>
        [XmlElement("charge")]
        public string Charge { get; set; }
    }
}
