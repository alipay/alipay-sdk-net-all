using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UnStandardBrandAddInfoOpenApi Data Structure.
    /// </summary>
    [Serializable]
    public class UnStandardBrandAddInfoOpenApi : AopObject
    {
        /// <summary>
        /// UN_STANDARD_E-COMMERCE：电商非标 LOCAL_LIFE：本地生活 CONTENT：内容 GOV_MET：政务民生 PLATFORM：平台 OTHER：其他
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("brand_category")]
        [XmlArrayItem("string")]
        public List<string> BrandCategory { get; set; }

        /// <summary>
        /// 对应brandCategory的类目名称
        /// </summary>
        [XmlElement("brand_category_name")]
        public string BrandCategoryName { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("certification_files")]
        [XmlArrayItem("brand_file_info_open_api")]
        public List<BrandFileInfoOpenApi> CertificationFiles { get; set; }

        /// <summary>
        /// REGISTRATION_CERTIFICATE：注册备案证书 ENTERPRISE_NAME：企业商号 DOOR_PITCHING：门头店招 GEOGRAPHIC_INDICATIONS：地理标志 OTHER：其他
        /// </summary>
        [XmlElement("certification_type")]
        public string CertificationType { get; set; }
    }
}
