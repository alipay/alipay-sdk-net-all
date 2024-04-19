using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionQueryResponse : AopResponse
    {
        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 版本列表
        /// </summary>
        [XmlArray("version_list")]
        [XmlArrayItem("mini_app_version_base_info")]
        public List<MiniAppVersionBaseInfo> VersionList { get; set; }
    }
}
