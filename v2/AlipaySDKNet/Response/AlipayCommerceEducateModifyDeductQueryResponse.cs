using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateModifyDeductQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateModifyDeductQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否允许修改
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }
    }
}
