using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeRecommendQueryResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeRecommendQueryResponse : AopResponse
    {
        /// <summary>
        /// 卡片内容的JS，可直接在浏览器打开。
        /// </summary>
        [XmlElement("card_url")]
        public string CardUrl { get; set; }
    }
}
