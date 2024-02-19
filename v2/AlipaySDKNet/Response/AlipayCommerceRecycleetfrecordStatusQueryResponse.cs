using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleetfrecordStatusQueryResponse.
    /// </summary>
    public class AlipayCommerceRecycleetfrecordStatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 申购结果
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }
    }
}
