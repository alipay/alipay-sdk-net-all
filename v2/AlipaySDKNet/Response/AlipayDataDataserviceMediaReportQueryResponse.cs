using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceMediaReportQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceMediaReportQueryResponse : AopResponse
    {
        /// <summary>
        /// 商家pid，类型是服务商并且传参里有m_pid的情况才会返回
        /// </summary>
        [XmlElement("m_pid")]
        public string MPid { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("m_pid_name")]
        public string MPidName { get; set; }

        /// <summary>
        /// 媒体报表数据列表
        /// </summary>
        [XmlArray("media_report_data_list")]
        [XmlArrayItem("media_report_detail")]
        public List<MediaReportDetail> MediaReportDataList { get; set; }

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
        /// 商户/服务商pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
