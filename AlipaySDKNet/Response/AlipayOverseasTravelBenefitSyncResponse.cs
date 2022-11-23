using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTravelBenefitSyncResponse.
    /// </summary>
    public class AlipayOverseasTravelBenefitSyncResponse : AopResponse
    {
        /// <summary>
        /// 流量端生成的权益id
        /// </summary>
        [XmlElement("client_benefit_id")]
        public string ClientBenefitId { get; set; }

        /// <summary>
        /// 扩展信息，json格式
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [XmlElement("result")]
        public ResultInfoDTO Result { get; set; }

        /// <summary>
        /// 同步结果状态
        /// </summary>
        [XmlElement("sync_status")]
        public string SyncStatus { get; set; }
    }
}
