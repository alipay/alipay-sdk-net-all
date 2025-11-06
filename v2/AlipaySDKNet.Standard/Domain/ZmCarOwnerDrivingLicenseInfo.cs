using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmCarOwnerDrivingLicenseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmCarOwnerDrivingLicenseInfo : AopObject
    {
        /// <summary>
        /// 驾驶证失效日期
        /// </summary>
        [XmlElement("license_expired_date")]
        public string LicenseExpiredDate { get; set; }

        /// <summary>
        /// 驾驶证图片url
        /// </summary>
        [XmlArray("license_img")]
        [XmlArrayItem("string")]
        public List<string> LicenseImg { get; set; }

        /// <summary>
        /// 准驾车型
        /// </summary>
        [XmlElement("license_level")]
        public string LicenseLevel { get; set; }

        /// <summary>
        /// 驾驶证编号，即身份证号
        /// </summary>
        [XmlElement("license_no")]
        public string LicenseNo { get; set; }

        /// <summary>
        /// 驾驶证状态
        /// </summary>
        [XmlElement("license_state")]
        public string LicenseState { get; set; }

        /// <summary>
        /// 验证等级，目前只有官方验证
        /// </summary>
        [XmlElement("verification_level")]
        public string VerificationLevel { get; set; }
    }
}
