using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIsponetestWzwtestWzwtestPreviewResponse.
    /// </summary>
    public class AlipayIsponetestWzwtestWzwtestPreviewResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("s")]
        public string S { get; set; }
    }
}
