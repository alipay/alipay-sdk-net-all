using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCreditAutofinanceLoanCloseResponse.
    /// </summary>
    public class AlipayCreditAutofinanceLoanCloseResponse : AopResponse
    {
        /// <summary>
        /// 外部平台订单号,64个字符以内、只能包含字母、数字、下划线；需保证在外部平台端不重复
        /// </summary>
        [XmlElement("outorderno")]
        public string Outorderno { get; set; }
    }
}
