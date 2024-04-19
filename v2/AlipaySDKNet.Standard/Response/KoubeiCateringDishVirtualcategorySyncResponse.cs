using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishVirtualcategorySyncResponse.
    /// </summary>
    public class KoubeiCateringDishVirtualcategorySyncResponse : AopResponse
    {
        /// <summary>
        /// 是否需要重试，true：需要重试；false：不需要
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }
    }
}
