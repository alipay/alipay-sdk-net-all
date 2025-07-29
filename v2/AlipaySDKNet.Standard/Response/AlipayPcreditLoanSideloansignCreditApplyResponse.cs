using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanSideloansignCreditApplyResponse.
    /// </summary>
    public class AlipayPcreditLoanSideloansignCreditApplyResponse : AopResponse
    {
        /// <summary>
        /// 冷静期类型
        /// </summary>
        [XmlElement("cool_off_type")]
        public string CoolOffType { get; set; }

        /// <summary>
        /// 授信申请状态
        /// </summary>
        [XmlElement("credit_status")]
        public string CreditStatus { get; set; }

        /// <summary>
        /// 业务原因编码
        /// </summary>
        [XmlElement("fail_reason_code")]
        public string FailReasonCode { get; set; }

        /// <summary>
        /// 业务失败原因描述
        /// </summary>
        [XmlElement("fail_reason_message")]
        public string FailReasonMessage { get; set; }

        /// <summary>
        /// 机构支用申请单号，成功受理时返回
        /// </summary>
        [XmlElement("institution_loan_apply_no")]
        public string InstitutionLoanApplyNo { get; set; }

        /// <summary>
        /// 表示请求处理状态
        /// </summary>
        [XmlElement("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// return_code为FAIL或者NEED_RETRY状态下，返回具体错误码。注意：支用通过与否通过异步通知
        /// </summary>
        [XmlElement("return_sub_code")]
        public string ReturnSubCode { get; set; }

        /// <summary>
        /// 可以详细描述失败原因，方便双方定位问题
        /// </summary>
        [XmlElement("return_sub_message")]
        public string ReturnSubMessage { get; set; }
    }
}
