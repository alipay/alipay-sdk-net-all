using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CategoryRequireInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CategoryRequireInfo : AopObject
    {
        /// <summary>
        /// 营业执照页面是否必填
        /// </summary>
        [XmlElement("business_licence_required")]
        public bool BusinessLicenceRequired { get; set; }

        /// <summary>
        /// 类目code（各级类目code下划线"_"拼接）
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 类目名称（各级类目名称下划线"_"拼接）
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 类目要求原始描述信息
        /// </summary>
        [XmlElement("category_requirements")]
        public string CategoryRequirements { get; set; }

        /// <summary>
        /// 门头照页面是否必填
        /// </summary>
        [XmlElement("door_photo_required")]
        public bool DoorPhotoRequired { get; set; }

        /// <summary>
        /// 特殊资质页面是否必填
        /// </summary>
        [XmlElement("special_licence_required")]
        public bool SpecialLicenceRequired { get; set; }
    }
}
