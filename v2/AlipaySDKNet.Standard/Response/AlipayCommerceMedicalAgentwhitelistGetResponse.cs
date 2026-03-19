using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalAgentwhitelistGetResponse.
    /// </summary>
    public class AlipayCommerceMedicalAgentwhitelistGetResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("white_list")]
        [XmlArrayItem("string")]
        public List<string> WhiteList { get; set; }
    }
}
