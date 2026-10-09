using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpAdminPenaltyPunishDetailsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpAdminPenaltyPunishDetailsInfo : AopObject
    {
        /// <summary>
        /// 类别
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 处罚时间
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 金额，单位元
        /// </summary>
        [XmlElement("money")]
        public string Money { get; set; }
    }
}
