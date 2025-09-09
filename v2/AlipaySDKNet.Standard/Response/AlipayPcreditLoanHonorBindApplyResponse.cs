using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanHonorBindApplyResponse.
    /// </summary>
    public class AlipayPcreditLoanHonorBindApplyResponse : AopResponse
    {
        /// <summary>
        /// 准入状态，1-准入成功，0-准入失败
        /// </summary>
        [XmlElement("access")]
        public long Access { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 咨询流水号，准入时有，授信申请提交需要带回
        /// </summary>
        [XmlElement("credit_consult_serial_no")]
        public string CreditConsultSerialNo { get; set; }

        /// <summary>
        /// true-跳过核身 false-需要核身 devmock能力。
        /// </summary>
        [XmlElement("exempt_verify")]
        public bool ExemptVerify { get; set; }

        /// <summary>
        /// 准入失败原因码
        /// </summary>
        [XmlElement("fail_code")]
        public string FailCode { get; set; }

        /// <summary>
        /// 准入失败原因，成功无需返回
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 授信拒绝管控期天
        /// </summary>
        [XmlElement("refuse_control_time")]
        public long RefuseControlTime { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        [XmlElement("refuse_msg_data")]
        public string RefuseMsgData { get; set; }

        /// <summary>
        /// 核身url
        /// </summary>
        [XmlElement("verify_url")]
        public string VerifyUrl { get; set; }
    }
}
