using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScenicTrafficTicketInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ScenicTrafficTicketInfo : AopObject
    {
        /// <summary>
        /// 检票时间
        /// </summary>
        [XmlElement("check_time")]
        public string CheckTime { get; set; }

        /// <summary>
        /// isv侧出发地景区id
        /// </summary>
        [XmlElement("departure_outer_scenic_id")]
        public string DepartureOuterScenicId { get; set; }

        /// <summary>
        /// isv侧目的地景区id
        /// </summary>
        [XmlElement("destination_outer_scenic_id")]
        public string DestinationOuterScenicId { get; set; }

        /// <summary>
        /// 扩展信息【废弃】
        /// </summary>
        [XmlElement("ext_info")]
        public ScenicExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 扩展信息。回流的key值请提前联系支付宝侧人员配置，否则回流的key值不会被消费
        /// </summary>
        [XmlArray("ext_infos")]
        [XmlArrayItem("scenic_ext_info")]
        public List<ScenicExtInfo> ExtInfos { get; set; }

        /// <summary>
        /// 乘客信息。
        /// </summary>
        [XmlElement("passengers")]
        public ScenicTrafficUserInfo Passengers { get; set; }

        /// <summary>
        /// 门票图片流的base64编码，大小不要超过1M。
        /// </summary>
        [XmlElement("pic")]
        public string Pic { get; set; }

        /// <summary>
        /// 景区小交通产品信息。
        /// </summary>
        [XmlElement("product_info")]
        public TrafficProductInfo ProductInfo { get; set; }

        /// <summary>
        /// 该车票数量
        /// </summary>
        [XmlElement("ticket_count")]
        public long TicketCount { get; set; }

        /// <summary>
        /// 门票名称
        /// </summary>
        [XmlElement("ticket_name")]
        public string TicketName { get; set; }

        /// <summary>
        /// isv侧门票唯一标识。
        /// </summary>
        [XmlElement("ticket_no")]
        public string TicketNo { get; set; }

        /// <summary>
        /// ADULT 成人票， CHILDREN 儿童票， OLD 老年票
        /// </summary>
        [XmlElement("ticket_specs")]
        public string TicketSpecs { get; set; }

        /// <summary>
        /// TO_USE 待核销， USED 已核销
        /// </summary>
        [XmlElement("ticket_status")]
        public string TicketStatus { get; set; }

        /// <summary>
        /// PASS 通票/时间段， POINT 时间点。  注意：对于时间点类型的小交通门票，使用开始时间和使用结束时间传值一致。
        /// </summary>
        [XmlElement("ticket_use_type")]
        public string TicketUseType { get; set; }

        /// <summary>
        /// 使用结束时间
        /// </summary>
        [XmlElement("use_end_time")]
        public string UseEndTime { get; set; }

        /// <summary>
        /// 使用开始时间
        /// </summary>
        [XmlElement("use_start_time")]
        public string UseStartTime { get; set; }
    }
}
