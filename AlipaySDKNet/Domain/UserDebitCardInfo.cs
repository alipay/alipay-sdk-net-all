using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserDebitCardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UserDebitCardInfo : AopObject
    {
        /// <summary>
        /// 借记卡户名
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 借记卡等账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 发卡行机构编码
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 借记卡发卡行
        /// </summary>
        [XmlElement("issuing_bank")]
        public string IssuingBank { get; set; }
    }
}
