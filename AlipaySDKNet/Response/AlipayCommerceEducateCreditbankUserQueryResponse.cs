using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCreditbankUserQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCreditbankUserQueryResponse : AopResponse
    {
        /// <summary>
        /// 学分银行id
        /// </summary>
        [XmlElement("cb_id")]
        public string CbId { get; set; }
    }
}
