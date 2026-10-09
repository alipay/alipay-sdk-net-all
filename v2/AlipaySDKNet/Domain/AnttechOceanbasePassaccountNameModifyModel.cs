using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbasePassaccountNameModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbasePassaccountNameModifyModel : AopObject
    {
        /// <summary>
        /// 账号类型
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 账号名称
        /// </summary>
        [XmlElement("new_account_name")]
        public string NewAccountName { get; set; }

        /// <summary>
        /// OceanBase Cloud的用户Id，可从个人中心获取
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }
    }
}
