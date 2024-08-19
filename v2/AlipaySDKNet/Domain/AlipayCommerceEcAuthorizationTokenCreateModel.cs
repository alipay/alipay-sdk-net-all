using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcAuthorizationTokenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcAuthorizationTokenCreateModel : AopObject
    {
        /// <summary>
        /// 授权码，和刷新令牌参数二选一
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 刷新令牌，和授权码参数二选一
        /// </summary>
        [XmlElement("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
