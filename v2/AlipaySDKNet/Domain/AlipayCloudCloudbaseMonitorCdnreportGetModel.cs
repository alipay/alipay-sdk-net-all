using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseMonitorCdnreportGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseMonitorCdnreportGetModel : AopObject
    {
        /// <summary>
        /// 小程序云AppID
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 小程序云环境ID
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 域名列表
        /// </summary>
        [XmlArray("domain_names")]
        [XmlArrayItem("string")]
        public List<string> DomainNames { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 报表类型  - TopUrlByAcc(热门 URL（按请求数排序）)  - TopUrlByTraf(热门 URL（按流量排序）)  - TopReferByAcc(热门 Referer（按请求数排序）)  - TopReferByTraf(热门 Referer（按流量排序）)  - OriginTopUrlByAcc(回源热门 URL（按请求数排序）)  - OriginTopUrlByTraf(回源热门 URL（按流量排序）)  - TopIpByAcc(Top 客户端 IP（按请求数排序）)  - TopIpByTraf(Top 客户端 IP（按流量排序）)  - DomainByTraf(域名排行（按流量排序）)  - DomainPvUv(PV 和 UV)  - AreaTrafStat(访问区域分布)  - IspTrafStat(运营商分布)
        /// </summary>
        [XmlElement("report_type")]
        public string ReportType { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
