using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceBookingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceBookingQueryModel : AopObject
    {
        /// <summary>
        /// 查询预约结束日期
        /// </summary>
        [XmlElement("booking_end_date")]
        public string BookingEndDate { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("booking_ids")]
        [XmlArrayItem("string")]
        public List<string> BookingIds { get; set; }

        /// <summary>
        /// 查询预约开始日期
        /// </summary>
        [XmlElement("booking_start_date")]
        public string BookingStartDate { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 预约人手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 蚂蚁门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("status_list")]
        [XmlArrayItem("string")]
        public List<string> StatusList { get; set; }
    }
}
