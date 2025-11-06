using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BrandInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class BrandInfoModel : AopObject
    {
        /// <summary>
        /// 商户品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 商户品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }
    }
}
