using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalOperationDeliverQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalOperationDeliverQueryResponse : AopResponse
    {
        /// <summary>
        /// 模版的投放内容
        /// </summary>
        [XmlElement("content_info")]
        public string ContentInfo { get; set; }
    }
}
