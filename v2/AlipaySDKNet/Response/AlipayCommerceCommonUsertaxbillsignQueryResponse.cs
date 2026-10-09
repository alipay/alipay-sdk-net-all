using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommonUsertaxbillsignQueryResponse.
    /// </summary>
    public class AlipayCommerceCommonUsertaxbillsignQueryResponse : AopResponse
    {
        /// <summary>
        /// 淘客与税筹公司的签约状态
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }
    }
}
