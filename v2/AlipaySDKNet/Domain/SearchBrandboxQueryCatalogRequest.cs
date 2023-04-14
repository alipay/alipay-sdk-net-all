using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchBrandboxQueryCatalogRequest Data Structure.
    /// </summary>
    [Serializable]
    public class SearchBrandboxQueryCatalogRequest : AopObject
    {
        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }
    }
}
