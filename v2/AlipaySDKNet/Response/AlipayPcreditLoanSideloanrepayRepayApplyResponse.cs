using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanSideloanrepayRepayApplyResponse.
    /// </summary>
    public class AlipayPcreditLoanSideloanrepayRepayApplyResponse : AopResponse
    {
        /// <summary>
        /// 扩展参数，预留字段，JSONString格式
        /// </summary>
        [XmlElement("extension")]
        public string Extension { get; set; }

        /// <summary>
        /// 蚂蚁还款受理单号，蚂蚁侧生成
        /// </summary>
        [XmlElement("institution_repayment_no")]
        public string InstitutionRepaymentNo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 收银台唤起参数
        /// </summary>
        [XmlElement("payment_params")]
        public string PaymentParams { get; set; }

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
