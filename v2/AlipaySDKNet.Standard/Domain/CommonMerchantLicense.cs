using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommonMerchantLicense Data Structure.
    /// </summary>
    [Serializable]
    public class CommonMerchantLicense : AopObject
    {
        /// <summary>
        /// 资质Code，包括登记管理部门代码、机构类型代码、行政区划码、主体识别码和校验码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 资质有效期 {dateFormat{yyyy-MM-dd}} 长期有效传入 9999-12-31
        /// </summary>
        [XmlElement("effective_date")]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// 资质名称。如营业执照就是营业执照的名称
        /// </summary>
        [XmlElement("license_name")]
        public string LicenseName { get; set; }

        /// <summary>
        /// 用户上传资质类型
        /// </summary>
        [XmlElement("license_type")]
        public string LicenseType { get; set; }

        /// <summary>
        /// 资质凭证图片链接,通过调用 ant.merchant.expand.indirect.image.upload(图片上传)接口返回的image_id作为参数
        /// </summary>
        [XmlArray("license_urls")]
        [XmlArrayItem("string")]
        public List<string> LicenseUrls { get; set; }
    }
}
