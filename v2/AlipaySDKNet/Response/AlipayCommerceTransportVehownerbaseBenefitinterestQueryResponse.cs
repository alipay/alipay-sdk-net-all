using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehownerbaseBenefitinterestQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportVehownerbaseBenefitinterestQueryResponse : AopResponse
    {
        /// <summary>
        /// 权益编码
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 权益详细信息，包含描述、值、类型等信息。
        /// </summary>
        [XmlElement("benefit_interest_info")]
        public BenefitInterestInfoResponse BenefitInterestInfo { get; set; }

        /// <summary>
        /// 权益激活状态。权益的生效状态需结合生效日期综合判断，即权益激活状态为S，且当前日期在生效日期内，权益为生效状态，其他情况为未生效状态。
        /// </summary>
        [XmlElement("benefit_status")]
        public string BenefitStatus { get; set; }

        /// <summary>
        /// 权益生效截止时间，格式为yyyy-MM-dd hh:mm:ss
        /// </summary>
        [XmlElement("effective_end_time")]
        public string EffectiveEndTime { get; set; }

        /// <summary>
        /// 权益生效起始时间，格式为yyyy-MM-dd hh:mm:ss
        /// </summary>
        [XmlElement("effective_start_time")]
        public string EffectiveStartTime { get; set; }

        /// <summary>
        /// 外部商户用户ID，用户关联用户信息
        /// </summary>
        [XmlElement("operator_user_id")]
        public string OperatorUserId { get; set; }

        /// <summary>
        /// 获取签名后的业务数据
        /// </summary>
        [XmlElement("orderStr")]
        public string OrderStr { get; set; }
    }
}
