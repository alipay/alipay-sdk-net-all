using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandBrandCreateResponse.
    /// </summary>
    public class AntMerchantExpandBrandCreateResponse : AopResponse
    {
        /// <summary>
        /// 品牌ID
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }
    }
}
