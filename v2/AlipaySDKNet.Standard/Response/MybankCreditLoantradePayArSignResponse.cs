using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradePayArSignResponse.
    /// </summary>
    public class MybankCreditLoantradePayArSignResponse : AopResponse
    {
        /// <summary>
        /// 错误码，表示请求失败出错
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 引导模型，是一个JSON形式字符串，内部key是引导key，value是引导内容。另外根据key的不同，引导内容本身也是一个JSON形式的字符串或者是一个普通的字符串
        /// </summary>
        [XmlElement("guide_param")]
        public string GuideParam { get; set; }

        /// <summary>
        /// 签约拒绝码，表示政策或者其它原因不准入，相比于error_code，拒绝码更加动态，原因多变
        /// </summary>
        [XmlElement("refuse_code")]
        public string RefuseCode { get; set; }

        /// <summary>
        /// 签约结果，合约类型-合约号，不涉及敏感信息
        /// </summary>
        [XmlElement("signed_ar")]
        public string SignedAr { get; set; }

        /// <summary>
        /// 是否签约成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
