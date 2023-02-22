using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAccountOperatorLogonpasswordVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAccountOperatorLogonpasswordVerifyModel : AopObject
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 操作员登录号
        /// </summary>
        [XmlElement("operator_logon_id")]
        public string OperatorLogonId { get; set; }

        /// <summary>
        /// 操作员登录密码
        /// </summary>
        [XmlElement("operator_logon_pwd")]
        public string OperatorLogonPwd { get; set; }
    }
}
