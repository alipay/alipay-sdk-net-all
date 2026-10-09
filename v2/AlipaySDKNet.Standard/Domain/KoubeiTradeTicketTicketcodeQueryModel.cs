using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiTradeTicketTicketcodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiTradeTicketTicketcodeQueryModel : AopObject
    {
        /// <summary>
        /// 口碑门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 券码值，12位纯数字券码，且唯一不重复。
        /// </summary>
        [XmlElement("ticket_code")]
        public string TicketCode { get; set; }
    }
}
