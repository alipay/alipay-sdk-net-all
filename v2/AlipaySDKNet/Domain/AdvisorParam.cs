using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AdvisorParam Data Structure.
    /// </summary>
    [Serializable]
    public class AdvisorParam : AopObject
    {
        /// <summary>
        /// 履约单列表
        /// </summary>
        [XmlArray("fulfillment_list")]
        [XmlArrayItem("string")]
        public List<string> FulfillmentList { get; set; }
    }
}
