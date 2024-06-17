using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppEbppInstnoticeCheckavailableResponse.
    /// </summary>
    public class AlipayEbppEbppInstnoticeCheckavailableResponse : AopResponse
    {
        /// <summary>
        /// CREATED：创建 PROCESSING：处理中 COMPLETED：完成 CANCELED：撤消
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
