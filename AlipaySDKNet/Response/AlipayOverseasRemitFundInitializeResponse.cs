using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasRemitFundInitializeResponse.
    /// </summary>
    public class AlipayOverseasRemitFundInitializeResponse : AopResponse
    {
        /// <summary>
        /// 合规检查的业务结果
        /// </summary>
        [XmlElement("compliance_check_result")]
        public string ComplianceCheckResult { get; set; }

        /// <summary>
        /// 合规检查的所有结果
        /// </summary>
        [XmlElement("compliance_check_result_info")]
        public string ComplianceCheckResultInfo { get; set; }

        /// <summary>
        /// 合规检查结果的签名
        /// </summary>
        [XmlElement("compliance_result_signature")]
        public string ComplianceResultSignature { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 外部单据号
        /// </summary>
        [XmlElement("external_biz_no")]
        public string ExternalBizNo { get; set; }

        /// <summary>
        /// 接收端的mid
        /// </summary>
        [XmlElement("receiver_mid")]
        public string ReceiverMid { get; set; }

        /// <summary>
        /// 发端的mid
        /// </summary>
        [XmlElement("sender_mid")]
        public string SenderMid { get; set; }
    }
}
