using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopLicenseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopLicenseInfo : AopObject
    {
        /// <summary>
        /// 证件到期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 主体证件名称
        /// </summary>
        [XmlElement("license_name")]
        public string LicenseName { get; set; }

        /// <summary>
        /// 主体证件号
        /// </summary>
        [XmlElement("license_no")]
        public string LicenseNo { get; set; }

        /// <summary>
        /// 主体证件图片
        /// </summary>
        [XmlElement("license_pic")]
        public string LicensePic { get; set; }
    }
}
