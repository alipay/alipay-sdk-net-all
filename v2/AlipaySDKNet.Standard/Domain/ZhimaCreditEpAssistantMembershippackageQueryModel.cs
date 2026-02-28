using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAssistantMembershippackageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAssistantMembershippackageQueryModel : AopObject
    {
        /// <summary>
        /// 会员包
        /// </summary>
        [XmlElement("package_id")]
        public string PackageId { get; set; }
    }
}
