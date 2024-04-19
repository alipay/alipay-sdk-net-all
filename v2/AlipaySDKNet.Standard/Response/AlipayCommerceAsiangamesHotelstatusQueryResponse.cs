using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAsiangamesHotelstatusQueryResponse.
    /// </summary>
    public class AlipayCommerceAsiangamesHotelstatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 列表展示
        /// </summary>
        [XmlArray("hotel_status_list")]
        [XmlArrayItem("hotel_status_info")]
        public List<HotelStatusInfo> HotelStatusList { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 返回页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询出来的总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
