using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticsAccountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsAccountInfo : AopObject
    {
        /// <summary>
        /// 商家在配送公司的账户的审核说明
        /// </summary>
        [XmlElement("audit_desc")]
        public string AuditDesc { get; set; }

        /// <summary>
        /// 商家在配送公司的账户id。
        /// </summary>
        [XmlElement("logistics_account_id")]
        public string LogisticsAccountId { get; set; }

        /// <summary>
        /// 商家在配送公司的账户状态
        /// </summary>
        [XmlElement("logistics_account_status")]
        public string LogisticsAccountStatus { get; set; }

        /// <summary>
        /// 商家的pid。
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
