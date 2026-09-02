using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorWifiBatchcreateResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorWifiBatchcreateResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("sol_wifi_info")]
        public List<SolWifiInfo> Data { get; set; }
    }
}
