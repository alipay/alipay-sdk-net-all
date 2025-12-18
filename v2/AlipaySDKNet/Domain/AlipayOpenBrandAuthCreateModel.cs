using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenBrandAuthCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenBrandAuthCreateModel : AopObject
    {
        /// <summary>
        /// 补充信息
        /// </summary>
        [XmlElement("brand_additional_info")]
        public BrandAuthAdditionalInfoOpenApi BrandAdditionalInfo { get; set; }

        /// <summary>
        /// 品牌授权材料
        /// </summary>
        [XmlElement("brand_auth_material")]
        public BrandAuthMaterialInfoOpenApi BrandAuthMaterial { get; set; }

        /// <summary>
        /// 在B站-品牌管理可以找到品牌id或者以B开头的品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }
    }
}
