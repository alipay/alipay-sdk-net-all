using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalServicepackageGrantbyphonenoCancelResponse.
    /// </summary>
    public class AlipayCommerceMedicalServicepackageGrantbyphonenoCancelResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("fail_order_no_list")]
        [XmlArrayItem("string")]
        public List<string> FailOrderNoList { get; set; }
    }
}
