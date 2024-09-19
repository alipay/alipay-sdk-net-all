using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupTicketSKU Data Structure.
    /// </summary>
    [Serializable]
    public class GroupTicketSKU : AopObject
    {
        /// <summary>
        /// 分类的名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 票种的列表
        /// </summary>
        [XmlArray("ticket_products")]
        [XmlArrayItem("ticket_s_k_u")]
        public List<TicketSKU> TicketProducts { get; set; }
    }
}
