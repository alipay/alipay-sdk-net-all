using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LubLegalCopyPersonInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LubLegalCopyPersonInfo : AopObject
    {
        /// <summary>
        /// 法人身份证反面图片URL
        /// </summary>
        [XmlElement("id_image_url_back")]
        public string IdImageUrlBack { get; set; }

        /// <summary>
        /// 法人身份证正面图片URL
        /// </summary>
        [XmlElement("id_image_url_front")]
        public string IdImageUrlFront { get; set; }

        /// <summary>
        /// 法人身份证姓名
        /// </summary>
        [XmlElement("id_legal_person_name")]
        public string IdLegalPersonName { get; set; }

        /// <summary>
        /// 法人身份证号
        /// </summary>
        [XmlElement("id_license_no")]
        public string IdLicenseNo { get; set; }

        /// <summary>
        /// 法人身份证有效期结束，格式 yyyy-MM-dd，空表示长期有效
        /// </summary>
        [XmlElement("id_valid_end_date")]
        public string IdValidEndDate { get; set; }

        /// <summary>
        /// 法人身份证有效期开始，格式 yyyy-MM-dd
        /// </summary>
        [XmlElement("id_valid_start_date")]
        public string IdValidStartDate { get; set; }
    }
}
