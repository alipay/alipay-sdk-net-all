using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniPluginuseconfigQueryResponse.
    /// </summary>
    public class AlipayOpenMiniPluginuseconfigQueryResponse : AopResponse
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 插件关联关系信息列表
        /// </summary>
        [XmlArray("plugin_relation_info_list")]
        [XmlArrayItem("plugin_use_relation_info")]
        public List<PluginUseRelationInfo> PluginRelationInfoList { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
