using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneInsureRecommendCheckResponse.
    /// </summary>
    public class AlipayInsSceneInsureRecommendCheckResponse : AopResponse
    {
        /// <summary>
        /// 是否能推荐保险true|false
        /// </summary>
        [XmlElement("access_result")]
        public bool AccessResult { get; set; }
    }
}
