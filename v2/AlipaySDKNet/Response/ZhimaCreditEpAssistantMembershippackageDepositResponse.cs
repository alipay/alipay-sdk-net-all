using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpAssistantMembershippackageDepositResponse.
    /// </summary>
    public class ZhimaCreditEpAssistantMembershippackageDepositResponse : AopResponse
    {
        /// <summary>
        /// 充值到的权益包id
        /// </summary>
        [XmlElement("package_id")]
        public string PackageId { get; set; }

        /// <summary>
        /// 会员包充值的记录id
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }
    }
}
