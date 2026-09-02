using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserUgshoppingOrderQueryResponse.
    /// </summary>
    public class AlipayUserUgshoppingOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("orders")]
        [XmlArrayItem("order_openapi")]
        public List<OrderOpenapi> Orders { get; set; }
    }
}
