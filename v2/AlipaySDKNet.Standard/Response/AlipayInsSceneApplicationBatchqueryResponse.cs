using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneApplicationBatchqueryResponse.
    /// </summary>
    public class AlipayInsSceneApplicationBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 投保单列表
        /// </summary>
        [XmlArray("applications")]
        [XmlArrayItem("ins_application_query")]
        public List<InsApplicationQuery> Applications { get; set; }
    }
}
