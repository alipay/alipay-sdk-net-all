using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinanceQuotationProtocolAuthorizeCheckResponse.
    /// </summary>
    public class AlipayFinanceQuotationProtocolAuthorizeCheckResponse : AopResponse
    {
        /// <summary>
        /// 协议最终是否订阅的结果
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("sub_protocol_result")]
        public List<SubProtocolResult> Result { get; set; }
    }
}
