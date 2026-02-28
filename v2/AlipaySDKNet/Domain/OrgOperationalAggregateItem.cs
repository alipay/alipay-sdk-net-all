using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrgOperationalAggregateItem Data Structure.
    /// </summary>
    [Serializable]
    public class OrgOperationalAggregateItem : AopObject
    {
        /// <summary>
        /// 问答UV
        /// </summary>
        [XmlElement("chat_uv")]
        public long ChatUv { get; set; }

        /// <summary>
        /// 数据日期
        /// </summary>
        [XmlElement("data_dt")]
        public string DataDt { get; set; }

        /// <summary>
        /// 互动UV
        /// </summary>
        [XmlElement("inter_uv")]
        public long InterUv { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        [XmlElement("org_name")]
        public string OrgName { get; set; }

        /// <summary>
        /// 门诊渗透率
        /// </summary>
        [XmlElement("outpatient_penetration_rate")]
        public string OutpatientPenetrationRate { get; set; }

        /// <summary>
        /// 门诊量
        /// </summary>
        [XmlElement("outpatient_pv")]
        public long OutpatientPv { get; set; }

        /// <summary>
        /// 服务点击UV
        /// </summary>
        [XmlElement("service_clk_uv")]
        public long ServiceClkUv { get; set; }

        /// <summary>
        /// 服务曝光UV
        /// </summary>
        [XmlElement("service_expo_uv")]
        public long ServiceExpoUv { get; set; }

        /// <summary>
        /// 服务点击UVCTR
        /// </summary>
        [XmlElement("service_uv_ctr")]
        public string ServiceUvCtr { get; set; }
    }
}
