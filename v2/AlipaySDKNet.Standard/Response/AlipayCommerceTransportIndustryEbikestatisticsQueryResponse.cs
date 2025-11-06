using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportIndustryEbikestatisticsQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportIndustryEbikestatisticsQueryResponse : AopResponse
    {
        /// <summary>
        /// query_type=month，date_str格式为yyyyMM； query_type=day，date_str格式为yyyyMMdd
        /// </summary>
        [XmlElement("date_str")]
        public string DateStr { get; set; }

        /// <summary>
        /// 页码，默认值1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页大小，默认值50
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询类型（month/day）  month：查询月数据 day：查询日数据
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// 两轮车服务绑车相关服务统计数据
        /// </summary>
        [XmlArray("record_list")]
        [XmlArrayItem("ebike_bind_service_statistics_d_t_o")]
        public List<EbikeBindServiceStatisticsDTO> RecordList { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
