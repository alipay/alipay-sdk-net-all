using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanSideloanrepayBudgetQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanSideloanrepayBudgetQueryResponse : AopResponse
    {
        /// <summary>
        /// 试算还款利息 单位:元, 精度:小数点后两位
        /// </summary>
        [XmlElement("calculate_repay_interest")]
        public string CalculateRepayInterest { get; set; }

        /// <summary>
        /// 试算还款罚息 单位:元, 精度:小数点后两位
        /// </summary>
        [XmlElement("calculate_repay_penalty")]
        public string CalculateRepayPenalty { get; set; }

        /// <summary>
        /// 试算还款本金 单位:元, 精度:小数点后两位
        /// </summary>
        [XmlElement("calculate_repay_principal")]
        public string CalculateRepayPrincipal { get; set; }

        /// <summary>
        /// 试算还款总金额 单位:元, 精度:小数点后两位, 口径:试算本金 + 试算利息 + 试算罚息
        /// </summary>
        [XmlElement("calculate_repay_total_amount")]
        public string CalculateRepayTotalAmount { get; set; }

        /// <summary>
        /// 扩展字段, 还款试算时会放入借据号列表和应还金额信息，还款提交时透传。
        /// </summary>
        [XmlElement("extension")]
        public string Extension { get; set; }

        /// <summary>
        /// 表示请求处理状态。 SUCCESS - 成功 NEED_RETRY -需要重试 FAIL - 不可重试
        /// </summary>
        [XmlElement("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// returnCode为FAIL或者NEED_RETRY状态下，返回具体错误码
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
