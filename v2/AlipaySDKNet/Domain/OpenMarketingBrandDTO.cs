using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenMarketingBrandDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenMarketingBrandDTO : AopObject
    {
        /// <summary>
        /// 品牌ID
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }
    }
}
