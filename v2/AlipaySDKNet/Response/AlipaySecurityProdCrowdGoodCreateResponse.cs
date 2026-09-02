using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdCrowdGoodCreateResponse.
    /// </summary>
    public class AlipaySecurityProdCrowdGoodCreateResponse : AopResponse
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("good_id")]
        public long GoodId { get; set; }
    }
}
