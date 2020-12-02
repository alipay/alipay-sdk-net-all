using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodeOrderdetailQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateTuitioncodeOrderdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 对象
        /// </summary>
        [XmlElement("data")]
        public RechargeOrderTuitionDTO Data { get; set; }
    }
}
