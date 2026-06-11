using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEbikeChargestationsQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportEbikeChargestationsQueryResponse : AopResponse
    {
        /// <summary>
        /// 所有品牌桩查看链接
        /// </summary>
        [XmlElement("all_brand_chargestations_link")]
        public string AllBrandChargestationsLink { get; set; }

        /// <summary>
        /// 所有品牌桩数据总量
        /// </summary>
        [XmlElement("all_brand_chargestations_total")]
        public long AllBrandChargestationsTotal { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("ebike_charge_station_list")]
        [XmlArrayItem("ebike_charge_station")]
        public List<EbikeChargeStation> EbikeChargeStationList { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 充电桩数据总量,单位:个
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
