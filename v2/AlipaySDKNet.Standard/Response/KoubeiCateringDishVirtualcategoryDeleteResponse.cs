using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishVirtualcategoryDeleteResponse.
    /// </summary>
    public class KoubeiCateringDishVirtualcategoryDeleteResponse : AopResponse
    {
        /// <summary>
        /// 是否重试，true：需要重试；false：不需要重试
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }
    }
}
