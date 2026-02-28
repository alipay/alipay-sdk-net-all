using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrgServiceMetric Data Structure.
    /// </summary>
    [Serializable]
    public class OrgServiceMetric : AopObject
    {
        /// <summary>
        /// 医疗机构ID
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        [XmlElement("org_name")]
        public string OrgName { get; set; }

        /// <summary>
        /// 医疗机构服务人次
        /// </summary>
        [XmlElement("uv_dt_td")]
        public long UvDtTd { get; set; }
    }
}
