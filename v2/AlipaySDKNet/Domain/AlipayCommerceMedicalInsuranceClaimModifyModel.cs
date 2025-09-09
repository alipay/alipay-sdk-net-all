using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceClaimModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceClaimModifyModel : AopObject
    {
        /// <summary>
        /// 理赔案件申请号，通过调用外部理赔申请接口时，支付宝自定义，传给外部接入方的申请号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 理赔案件号，外部接入方理赔案件的唯一标识
        /// </summary>
        [XmlElement("claim_no")]
        public string ClaimNo { get; set; }

        /// <summary>
        /// 案件状态及其他信息
        /// </summary>
        [XmlElement("claim_status_info")]
        public ClaimStatusInfo ClaimStatusInfo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 理赔案件下，支付流水维度的赔付信息
        /// </summary>
        [XmlArray("serial_infos")]
        [XmlArrayItem("serial_info")]
        public List<SerialInfo> SerialInfos { get; set; }

        /// <summary>
        /// 请求来源，由支付宝统一提供固定值
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
