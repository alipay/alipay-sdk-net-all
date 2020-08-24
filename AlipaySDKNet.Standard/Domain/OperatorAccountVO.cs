using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OperatorAccountVO Data Structure.
    /// </summary>
    [Serializable]
    public class OperatorAccountVO : AopObject
    {
        /// <summary>
        /// 关联账号ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 关联账号类型。枚举值参考OperatorRelAccountTypeEnum account_type=01，则account_id为支付宝userId account_type=02，则account_id为钉钉账号id account_type=03，则account_id为支付宝oid
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }
    }
}
