using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PunishStatusResult Data Structure.
    /// </summary>
    [Serializable]
    public class PunishStatusResult : AopObject
    {
        /// <summary>
        /// 需求code
        /// </summary>
        [XmlElement("demand_code")]
        public string DemandCode { get; set; }

        /// <summary>
        /// 主体Id
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// pc端自解限跳转URL
        /// </summary>
        [XmlElement("pc_relieve_url")]
        public string PcRelieveUrl { get; set; }

        /// <summary>
        /// app端自解限跳转URL
        /// </summary>
        [XmlElement("relieve_url")]
        public string RelieveUrl { get; set; }

        /// <summary>
        /// 处置状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
