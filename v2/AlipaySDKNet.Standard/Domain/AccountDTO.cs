using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccountDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AccountDTO : AopObject
    {
        /// <summary>
        /// 户名
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 银行机构代码，如工商银行为ICBC
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 开户网点
        /// </summary>
        [XmlElement("offical_name")]
        public string OfficalName { get; set; }

        /// <summary>
        /// 联行号
        /// </summary>
        [XmlElement("offical_number")]
        public string OfficalNumber { get; set; }
    }
}
