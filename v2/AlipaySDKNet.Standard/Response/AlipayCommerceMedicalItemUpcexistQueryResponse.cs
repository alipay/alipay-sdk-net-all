using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalItemUpcexistQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalItemUpcexistQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("upc_list")]
        [XmlArrayItem("string")]
        public List<string> UpcList { get; set; }
    }
}
