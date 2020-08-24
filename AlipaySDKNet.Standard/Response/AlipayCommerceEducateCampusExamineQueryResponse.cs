using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCampusExamineQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCampusExamineQueryResponse : AopResponse
    {
        /// <summary>
        /// 审核未通过原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
