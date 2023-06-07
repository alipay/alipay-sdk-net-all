using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandBrandCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandBrandCreateModel : AopObject
    {
        /// <summary>
        /// 品牌中文名，中文名与英文名至少填写一个。
        /// </summary>
        [XmlElement("brand_chs_name")]
        public string BrandChsName { get; set; }

        /// <summary>
        /// 品牌英文名，中文名与英文名至少填写一个。
        /// </summary>
        [XmlElement("brand_eng_name")]
        public string BrandEngName { get; set; }

        /// <summary>
        /// 品牌运营主体的pid
        /// </summary>
        [XmlElement("carrier_id")]
        public string CarrierId { get; set; }

        /// <summary>
        /// 需传入ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id。
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }
    }
}
