using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpAssistantMembershippackageCreateResponse.
    /// </summary>
    public class ZhimaCreditEpAssistantMembershippackageCreateResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("licenses")]
        [XmlArrayItem("string")]
        public List<string> Licenses { get; set; }

        /// <summary>
        /// 会员包编码
        /// </summary>
        [XmlElement("package_id")]
        public string PackageId { get; set; }
    }
}
