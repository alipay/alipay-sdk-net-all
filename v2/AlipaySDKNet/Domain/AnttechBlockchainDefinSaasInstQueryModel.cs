using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinSaasInstQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinSaasInstQueryModel : AopObject
    {
        /// <summary>
        /// 机构名称
        /// </summary>
        [XmlElement("channel_name")]
        public string ChannelName { get; set; }

        /// <summary>
        /// 业务平台Id
        /// </summary>
        [XmlElement("platform_member_id")]
        public string PlatformMemberId { get; set; }
    }
}
