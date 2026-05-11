using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalFulfillmentListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalFulfillmentListQueryModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("query_data")]
        [XmlArrayItem("query_data")]
        public List<QueryData> QueryData { get; set; }
    }
}
