using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanSideloanlendElementConsultResponse.
    /// </summary>
    public class AlipayPcreditLoanSideloanlendElementConsultResponse : AopResponse
    {
        /// <summary>
        /// TRUE：支用准入，FALSE：支用不准入
        /// </summary>
        [XmlElement("admit")]
        public bool Admit { get; set; }

        /// <summary>
        /// 用户默认放款卡，可能为空
        /// </summary>
        [XmlElement("default_bank_card")]
        public GrantBankCard DefaultBankCard { get; set; }

        /// <summary>
        /// 业务扩展信息
        /// </summary>
        [XmlElement("extension")]
        public string Extension { get; set; }

        /// <summary>
        /// admit=false时必填，返回不准入拒绝码
        /// </summary>
        [XmlElement("fail_reason_code")]
        public string FailReasonCode { get; set; }

        /// <summary>
        /// 当admit=false时必选，返回拒绝原因
        /// </summary>
        [XmlElement("fail_reason_message")]
        public string FailReasonMessage { get; set; }

        /// <summary>
        /// 支持的还款方式及还款期次列表，JSONString, Map<String,RepaymentMethodAndTerm>
        /// </summary>
        [XmlElement("repayment_method_and_term_map")]
        public string RepaymentMethodAndTermMap { get; set; }

        /// <summary>
        /// 表示请求处理状态。可选值： SUCCESS - 成功 NEED_RETRY - 需要重试 FAIL - 不可重试
        /// </summary>
        [XmlElement("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// 二级错误码，返回具体业务错误码
        /// </summary>
        [XmlElement("return_sub_code")]
        public string ReturnSubCode { get; set; }

        /// <summary>
        /// 二级错误码，可以详细描述失败原因，方便双方定位问题
        /// </summary>
        [XmlElement("return_sub_message")]
        public string ReturnSubMessage { get; set; }

        /// <summary>
        /// 当用户命中安全的限权，且允许用户操作解限时此值不为空，用户可跳转链接操作解限
        /// </summary>
        [XmlElement("un_limit_url")]
        public string UnLimitUrl { get; set; }
    }
}
