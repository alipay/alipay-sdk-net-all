using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpInteopEnterprisecodeCreateResponse.
    /// </summary>
    public class AlipayOpenSpInteopEnterprisecodeCreateResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("memos")]
        [XmlArrayItem("string")]
        public List<string> Memos { get; set; }

        /// <summary>
        /// 一体化作业子单号
        /// </summary>
        [XmlElement("sub_order_no")]
        public string SubOrderNo { get; set; }
    }
}
