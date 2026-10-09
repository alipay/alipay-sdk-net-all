using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinSaasInstQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinSaasInstQueryResponse : AopResponse
    {
        /// <summary>
        /// 机构编码
        /// </summary>
        [XmlElement("channel_member_code")]
        public string ChannelMemberCode { get; set; }

        /// <summary>
        /// 机构网点联行号
        /// </summary>
        [XmlElement("channel_official_number")]
        public string ChannelOfficialNumber { get; set; }
    }
}
