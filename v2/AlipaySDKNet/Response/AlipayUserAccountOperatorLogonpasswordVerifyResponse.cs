using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAccountOperatorLogonpasswordVerifyResponse.
    /// </summary>
    public class AlipayUserAccountOperatorLogonpasswordVerifyResponse : AopResponse
    {
        /// <summary>
        /// PASSWORD_NOT_MATCH 密码不匹配 PASSWORD_LOCKED 密码暂时锁定 CIF_SYSTEM_FAILURE 系统错误
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 密码错误次数
        /// </summary>
        [XmlElement("fail_times")]
        public long FailTimes { get; set; }

        /// <summary>
        /// 密码校验通过返回true，否则返回false
        /// </summary>
        [XmlElement("verify_success")]
        public bool VerifySuccess { get; set; }
    }
}
