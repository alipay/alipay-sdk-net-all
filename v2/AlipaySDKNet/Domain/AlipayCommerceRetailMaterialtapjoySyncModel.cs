using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRetailMaterialtapjoySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRetailMaterialtapjoySyncModel : AopObject
    {
        /// <summary>
        /// 广告id标识
        /// </summary>
        [XmlElement("ad_id")]
        public string AdId { get; set; }

        /// <summary>
        /// 素材关联的品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 素材图片url地址
        /// </summary>
        [XmlElement("material_url")]
        public string MaterialUrl { get; set; }
    }
}
