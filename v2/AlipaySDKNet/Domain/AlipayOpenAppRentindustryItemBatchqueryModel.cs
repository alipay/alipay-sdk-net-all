using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppRentindustryItemBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppRentindustryItemBatchqueryModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("out_item_ids")]
        [XmlArrayItem("string")]
        public List<string> OutItemIds { get; set; }
    }
}
