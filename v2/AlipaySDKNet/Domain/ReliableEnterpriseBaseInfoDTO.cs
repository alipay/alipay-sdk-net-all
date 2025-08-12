using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReliableEnterpriseBaseInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ReliableEnterpriseBaseInfoDTO : AopObject
    {
        /// <summary>
        /// 企业认证状态，不传默认为NO_AUTH
        /// </summary>
        [XmlElement("auth_status")]
        public string AuthStatus { get; set; }

        /// <summary>
        /// 企业注册页面需要回显的统一社会信用代码，只能是数字和字母组成
        /// </summary>
        [XmlElement("enterprise_code")]
        public string EnterpriseCode { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("enterprise_name")]
        public string EnterpriseName { get; set; }
    }
}
