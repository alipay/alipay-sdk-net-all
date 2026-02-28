using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentServiceTicketInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentServiceTicketInfo : AopObject
    {
        /// <summary>
        /// 收货地址
        /// </summary>
        [XmlElement("address_info")]
        public RentServiceTicketReceiverAddressInfoDTO AddressInfo { get; set; }

        /// <summary>
        /// 服务单的业务主状态
        /// </summary>
        [XmlElement("biz_main_status")]
        public string BizMainStatus { get; set; }

        /// <summary>
        /// 业务子状态
        /// </summary>
        [XmlElement("biz_sub_status")]
        public string BizSubStatus { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 服务单号
        /// </summary>
        [XmlElement("service_ticket_id")]
        public string ServiceTicketId { get; set; }

        /// <summary>
        /// 服务工单类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
