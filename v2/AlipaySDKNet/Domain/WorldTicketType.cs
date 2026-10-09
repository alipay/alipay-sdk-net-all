using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WorldTicketType Data Structure.
    /// </summary>
    [Serializable]
    public class WorldTicketType : AopObject
    {
        /// <summary>
        /// 票种代码
        /// </summary>
        [XmlElement("ticket_type_code")]
        public string TicketTypeCode { get; set; }

        /// <summary>
        /// 票种描述
        /// </summary>
        [XmlElement("ticket_type_desc")]
        public string TicketTypeDesc { get; set; }

        /// <summary>
        /// 票种名称
        /// </summary>
        [XmlElement("ticket_type_name")]
        public string TicketTypeName { get; set; }
    }
}
