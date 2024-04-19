using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditamountQueryprocessorQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditamountQueryprocessorQueryResponse : AopResponse
    {
        /// <summary>
        /// 报错原因
        /// </summary>
        [XmlElement("error_context")]
        public string ErrorContext { get; set; }

        /// <summary>
        /// 响应体
        /// </summary>
        [XmlElement("response")]
        public TbapiQueryAmountResponse Response { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
