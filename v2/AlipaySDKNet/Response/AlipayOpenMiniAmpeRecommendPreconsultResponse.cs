using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeRecommendPreconsultResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeRecommendPreconsultResponse : AopResponse
    {
        /// <summary>
        /// 预估是否有推荐的内容，如果是true，则表示有推荐内容，需要展示卡片。
        /// </summary>
        [XmlElement("show_widget")]
        public string ShowWidget { get; set; }
    }
}
