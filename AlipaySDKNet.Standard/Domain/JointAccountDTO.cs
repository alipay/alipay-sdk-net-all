using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JointAccountDTO Data Structure.
    /// </summary>
    [Serializable]
    public class JointAccountDTO : AopObject
    {
        /// <summary>
        /// 共同账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 共同账户账本名称
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 账本创建人会员号
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
