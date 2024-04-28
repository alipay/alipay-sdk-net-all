using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockTestQueryResponse.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockTestQueryResponse : AopResponse
    {
        /// <summary>
        /// 哈哈
        /// </summary>
        [XmlElement("out_open_id")]
        public string OutOpenId { get; set; }

        /// <summary>
        /// 哈哈
        /// </summary>
        [XmlElement("out_test")]
        public string OutTest { get; set; }
    }
}
