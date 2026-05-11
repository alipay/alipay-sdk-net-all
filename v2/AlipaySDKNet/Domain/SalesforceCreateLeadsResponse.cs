using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SalesforceCreateLeadsResponse Data Structure.
    /// </summary>
    [Serializable]
    public class SalesforceCreateLeadsResponse : AopObject
    {
        /// <summary>
        /// 商机id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
