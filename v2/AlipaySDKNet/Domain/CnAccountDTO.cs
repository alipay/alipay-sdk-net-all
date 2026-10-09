using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CnAccountDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CnAccountDTO : AopObject
    {
        /// <summary>
        /// 跨境游营销机构Id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 营销机构账号名
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }
    }
}
