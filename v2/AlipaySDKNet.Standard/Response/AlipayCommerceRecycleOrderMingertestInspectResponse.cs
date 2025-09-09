using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleOrderMingertestInspectResponse.
    /// </summary>
    public class AlipayCommerceRecycleOrderMingertestInspectResponse : AopResponse
    {
        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("assess_product")]
        public RecycleAssessProductVO AssessProduct { get; set; }
    }
}
