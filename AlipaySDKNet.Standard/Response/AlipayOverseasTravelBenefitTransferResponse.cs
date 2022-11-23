using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTravelBenefitTransferResponse.
    /// </summary>
    public class AlipayOverseasTravelBenefitTransferResponse : AopResponse
    {
        /// <summary>
        /// 权益详情链接
        /// </summary>
        [XmlElement("benefit_detail_url")]
        public string BenefitDetailUrl { get; set; }

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
