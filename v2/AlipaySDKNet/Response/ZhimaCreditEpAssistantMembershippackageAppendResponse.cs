using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpAssistantMembershippackageAppendResponse.
    /// </summary>
    public class ZhimaCreditEpAssistantMembershippackageAppendResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("license_detail_list")]
        [XmlArrayItem("assistant_license_info")]
        public List<AssistantLicenseInfo> LicenseDetailList { get; set; }

        /// <summary>
        /// 会员包编码
        /// </summary>
        [XmlElement("package_id")]
        public string PackageId { get; set; }
    }
}
