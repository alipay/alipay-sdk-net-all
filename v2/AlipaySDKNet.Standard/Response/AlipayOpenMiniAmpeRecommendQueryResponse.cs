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

        /// <summary>
        /// 用于标记当前咨询请求是否需要展示卡片，在不同场景下含义不同。例如在蚂蚁森林场景下，如果用户有待收取的能量，那么值为true。
        /// </summary>
        [XmlElement("show_widget")]
        public string ShowWidget { get; set; }
    }
}
