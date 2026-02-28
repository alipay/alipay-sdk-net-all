using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTrafficshareCrowdSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportTrafficshareCrowdSyncResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("phone_number_list")]
        [XmlArrayItem("string")]
        public List<string> PhoneNumberList { get; set; }
    }
}
