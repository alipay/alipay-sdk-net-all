using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApplyBusinessPropertyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApplyBusinessPropertyDTO : AopObject
    {
        /// <summary>
        /// 联系人信息
        /// </summary>
        [XmlArray("contacts")]
        [XmlArrayItem("business_contact_d_t_o")]
        public List<BusinessContactDTO> Contacts { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        [XmlElement("extend")]
        public string Extend { get; set; }

        /// <summary>
        /// 营业执照资质
        /// </summary>
        [XmlElement("license")]
        public BusinessLicenseDTO License { get; set; }

        /// <summary>
        /// MCC 枚举值
        /// </summary>
        [XmlElement("mcc_code")]
        public string MccCode { get; set; }

        /// <summary>
        /// 经营类目类型
        /// </summary>
        [XmlElement("mcc_type")]
        public string MccType { get; set; }

        /// <summary>
        /// 特殊资质信息
        /// </summary>
        [XmlArray("special_license")]
        [XmlArrayItem("business_special_license_d_t_o")]
        public List<BusinessSpecialLicenseDTO> SpecialLicense { get; set; }

        /// <summary>
        /// 网站信息
        /// </summary>
        [XmlArray("web_apps")]
        [XmlArrayItem("business_web_app_d_t_o")]
        public List<BusinessWebAppDTO> WebApps { get; set; }
    }
}
