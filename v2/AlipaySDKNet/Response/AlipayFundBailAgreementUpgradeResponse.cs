using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundBailAgreementUpgradeResponse.
    /// </summary>
    public class AlipayFundBailAgreementUpgradeResponse : AopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 保证金接口迁移是否成功
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
