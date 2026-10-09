using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MarketingItemSelection Data Structure.
    /// </summary>
    [Serializable]
    public class MarketingItemSelection : AopObject
    {
        /// <summary>
        /// 营销项目ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
