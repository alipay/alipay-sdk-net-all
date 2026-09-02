using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LubBusinessLicenseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LubBusinessLicenseInfo : AopObject
    {
        /// <summary>
        /// 营业执照图片OSS Key
        /// </summary>
        [XmlElement("bl_image_oss")]
        public string BlImageOss { get; set; }

        /// <summary>
        /// 营业执照图片URL
        /// </summary>
        [XmlElement("bl_image_url")]
        public string BlImageUrl { get; set; }

        /// <summary>
        /// 营业执照法人姓名
        /// </summary>
        [XmlElement("bl_legal_person_name")]
        public string BlLegalPersonName { get; set; }

        /// <summary>
        /// 营业执照主体名称
        /// </summary>
        [XmlElement("bl_license_name")]
        public string BlLicenseName { get; set; }

        /// <summary>
        /// 营业执照编号（统一社会信用代码）
        /// </summary>
        [XmlElement("bl_license_no")]
        public string BlLicenseNo { get; set; }

        /// <summary>
        /// 营业执照有效期结束，格式 yyyy-MM-dd，空表示长期有效
        /// </summary>
        [XmlElement("bl_valid_end_date")]
        public string BlValidEndDate { get; set; }

        /// <summary>
        /// 营业执照有效期开始，格式 yyyy-MM-dd
        /// </summary>
        [XmlElement("bl_valid_start_date")]
        public string BlValidStartDate { get; set; }
    }
}
