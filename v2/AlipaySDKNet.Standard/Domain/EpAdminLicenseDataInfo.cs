using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpAdminLicenseDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpAdminLicenseDataInfo : AopObject
    {
        /// <summary>
        /// 查询企业行政许可内容明细
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("ep_admin_license_info")]
        public List<EpAdminLicenseInfo> Hits { get; set; }

        /// <summary>
        /// 命中记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
