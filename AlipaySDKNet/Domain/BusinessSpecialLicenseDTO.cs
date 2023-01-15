using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessSpecialLicenseDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessSpecialLicenseDTO : AopObject
    {
        /// <summary>
        /// 特殊资质图片
        /// </summary>
        [XmlElement("license_pic")]
        public string LicensePic { get; set; }

        /// <summary>
        /// 特殊资质类型
        /// </summary>
        [XmlElement("license_type")]
        public string LicenseType { get; set; }
    }
}
