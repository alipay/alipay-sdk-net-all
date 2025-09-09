using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanSideloansignApplyQuerystatusResponse.
    /// </summary>
    public class AlipayPcreditLoanSideloansignApplyQuerystatusResponse : AopResponse
    {
        /// <summary>
        /// 冷静期类型，LONG-长，SHORT-短，NONE-无
        /// </summary>
        [XmlElement("cool_off_type")]
        public string CoolOffType { get; set; }

        /// <summary>
        /// 签约奖品发放结果
        /// </summary>
        [XmlElement("coupon_send_result")]
        public CouponSendResult CouponSendResult { get; set; }

        /// <summary>
        /// 授信成功后返回，授信总额度，单位元，保留两位小数
        /// </summary>
        [XmlElement("credit_quota")]
        public string CreditQuota { get; set; }

        /// <summary>
        /// 用户授信申请状态
        /// </summary>
        [XmlElement("credit_status")]
        public string CreditStatus { get; set; }

        /// <summary>
        /// 授信通过时间（格式yyyy-MM-ddHH:mm:ss ）
        /// </summary>
        [XmlElement("credit_time")]
        public string CreditTime { get; set; }

        /// <summary>
        /// 授信失效日期
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 授信申请失败时返回拒绝原因码
        /// </summary>
        [XmlElement("fail_reason_code")]
        public string FailReasonCode { get; set; }

        /// <summary>
        /// 返回失败原因描述
        /// </summary>
        [XmlElement("fail_reason_message")]
        public string FailReasonMessage { get; set; }

        /// <summary>
        /// 授信机构编码
        /// </summary>
        [XmlElement("fund_supplier_code")]
        public string FundSupplierCode { get; set; }

        /// <summary>
        /// 蚂蚁授信申请受理单号
        /// </summary>
        [XmlElement("institution_credit_apply_no")]
        public string InstitutionCreditApplyNo { get; set; }

        /// <summary>
        /// 授信拒绝后，下次可以申请的时间 永远不允许是 9999-12-31 23:59:59
        /// </summary>
        [XmlElement("next_available_apply_time")]
        public string NextAvailableApplyTime { get; set; }

        /// <summary>
        /// 请求的处理结果状态，可选值： SUCCESS - 成功 NEED_RETRY - 需要重试 FAIL - 不可重试
        /// </summary>
        [XmlElement("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// returnCode为FAIL或者 NEED_RETRY状态下，返回具体 错误码
        /// </summary>
        [XmlElement("return_sub_code")]
        public string ReturnSubCode { get; set; }

        /// <summary>
        /// 对returnSubCode失败的具体详情
        /// </summary>
        [XmlElement("return_sub_message")]
        public string ReturnSubMessage { get; set; }

        /// <summary>
        /// 授信生效日期
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
