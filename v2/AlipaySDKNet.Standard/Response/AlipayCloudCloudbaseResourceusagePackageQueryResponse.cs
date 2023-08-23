using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseResourceusagePackageQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseResourceusagePackageQueryResponse : AopResponse
    {
        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 各计费项用量列表
        /// </summary>
        [XmlArray("package_usages")]
        [XmlArrayItem("package_usage")]
        public List<PackageUsage> PackageUsages { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
