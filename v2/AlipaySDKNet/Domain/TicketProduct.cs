using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TicketProduct Data Structure.
    /// </summary>
    [Serializable]
    public class TicketProduct : AopObject
    {
        /// <summary>
        /// 票务是否区分人群
        /// </summary>
        [XmlElement("group")]
        public bool Group { get; set; }

        /// <summary>
        /// 按照分组的票务SKU信息
        /// </summary>
        [XmlArray("group_ticket_products")]
        [XmlArrayItem("group_ticket_s_k_u")]
        public List<GroupTicketSKU> GroupTicketProducts { get; set; }

        /// <summary>
        /// 如果不需要分类的情况下的票种列表
        /// </summary>
        [XmlArray("ticket_products")]
        [XmlArrayItem("ticket_s_k_u")]
        public List<TicketSKU> TicketProducts { get; set; }

        /// <summary>
        /// 门票
        /// </summary>
        [XmlElement("ticket_type")]
        public string TicketType { get; set; }
    }
}
