using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanSideloansignCloseApplyResponse.
    /// </summary>
    public class AlipayPcreditLoanSideloansignCloseApplyResponse : AopResponse
    {
        /// <summary>
        /// 失败原因描述
        /// </summary>
        [XmlElement("fail_reanson_message")]
        public string FailReansonMessage { get; set; }

        /// <summary>
        /// 失败原因编码
        /// </summary>
        [XmlElement("fail_reason_code")]
        public string FailReasonCode { get; set; }

        /// <summary>
        /// 关闭申请状态，可选值： SUCCESS - 成功 FAIL - 失败
        /// </summary>
        [XmlElement("quit_status")]
        public string QuitStatus { get; set; }

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
