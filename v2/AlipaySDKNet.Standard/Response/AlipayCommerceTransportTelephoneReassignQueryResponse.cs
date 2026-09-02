using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTelephoneReassignQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportTelephoneReassignQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("reassign_number_result")]
        public List<ReassignNumberResult> ResultList { get; set; }
    }
}
