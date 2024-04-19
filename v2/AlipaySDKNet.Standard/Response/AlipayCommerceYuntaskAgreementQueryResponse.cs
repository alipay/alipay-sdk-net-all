using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskAgreementQueryResponse.
    /// </summary>
    public class AlipayCommerceYuntaskAgreementQueryResponse : AopResponse
    {
        /// <summary>
        /// 签约状态，TEMP：暂存，协议未生效过；NORMAL：正常；STOP：暂停
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
