using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppAppcontentItemBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppAppcontentItemBatchqueryModel : AopObject
    {
        /// <summary>
        /// 商品ID列表；最多20个ID
        /// </summary>
        [XmlArray("item_ids")]
        [XmlArrayItem("string")]
        public List<string> ItemIds { get; set; }
    }
}
