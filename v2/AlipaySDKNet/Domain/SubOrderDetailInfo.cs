using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubOrderDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SubOrderDetailInfo : AopObject
    {
        /// <summary>
        /// 门票描述信息
        /// </summary>
        [XmlElement("good_desc")]
        public string GoodDesc { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("good_id")]
        public string GoodId { get; set; }

        /// <summary>
        /// 门票中文描述
        /// </summary>
        [XmlElement("good_name")]
        public string GoodName { get; set; }

        /// <summary>
        /// 门票数量
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 子订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 游客信息
        /// </summary>
        [XmlArray("passagers")]
        [XmlArrayItem("ticket_passager_info")]
        public List<TicketPassagerInfo> Passagers { get; set; }
    }
}
