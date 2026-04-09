using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpAssistantMembershippackageOrderResponse.
    /// </summary>
    public class ZhimaCreditEpAssistantMembershippackageOrderResponse : AopResponse
    {
        /// <summary>
        /// 会员包生效时间
        /// </summary>
        [XmlElement("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 会员包失效时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

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
