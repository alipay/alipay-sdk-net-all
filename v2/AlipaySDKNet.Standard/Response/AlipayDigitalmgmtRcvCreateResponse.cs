using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtRcvCreateResponse.
    /// </summary>
    public class AlipayDigitalmgmtRcvCreateResponse : AopResponse
    {
        /// <summary>
        /// rcv编码列表
        /// </summary>
        [XmlArray("rcv_number_list")]
        [XmlArrayItem("string")]
        public List<string> RcvNumberList { get; set; }
    }
}
