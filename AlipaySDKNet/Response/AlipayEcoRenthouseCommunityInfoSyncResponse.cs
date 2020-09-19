using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoRenthouseCommunityInfoSyncResponse.
    /// </summary>
    public class AlipayEcoRenthouseCommunityInfoSyncResponse : AopResponse
    {
        /// <summary>
        /// 小区同步请求号
        /// </summary>
        [XmlElement("comm_req_id")]
        public string CommReqId { get; set; }

        /// <summary>
        /// 小区审核拒绝原因
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 小区同步状态
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
