using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTravelBenefitQueryResponse.
    /// </summary>
    public class AlipayOverseasTravelBenefitQueryResponse : AopResponse
    {
        /// <summary>
        /// 流量端生成的权益id,只在权益同步成功时才返回
        /// </summary>
        [XmlElement("client_benefit_id")]
        public string ClientBenefitId { get; set; }

        /// <summary>
        /// 扩展
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [XmlElement("result")]
        public ResultInfoDTO Result { get; set; }

        /// <summary>
        /// 同步失败错误码
        /// </summary>
        [XmlElement("sync_fail_code")]
        public string SyncFailCode { get; set; }

        /// <summary>
        /// 同步失败原因
        /// </summary>
        [XmlElement("sync_fail_reason")]
        public string SyncFailReason { get; set; }

        /// <summary>
        /// 同步处理状态，合法取值： PROCESSING：处理中 SUCCESS：处理成功 FAIL：处理失败
        /// </summary>
        [XmlElement("sync_status")]
        public string SyncStatus { get; set; }
    }
}
