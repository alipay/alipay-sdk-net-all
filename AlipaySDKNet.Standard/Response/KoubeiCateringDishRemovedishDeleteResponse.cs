using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishRemovedishDeleteResponse.
    /// </summary>
    public class KoubeiCateringDishRemovedishDeleteResponse : AopResponse
    {
        /// <summary>
        /// 失败是否需要重试，true：需要重试；false：不需要重试。
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }
    }
}
