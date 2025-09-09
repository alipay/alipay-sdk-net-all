using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiOperationalAnalysisTrafficSourceResult Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiOperationalAnalysisTrafficSourceResult : AopObject
    {
        /// <summary>
        /// 流量来源分析数据
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("open_api_operation_analysis_traffic_source_alias_d_t_o")]
        public List<OpenApiOperationAnalysisTrafficSourceAliasDTO> Items { get; set; }
    }
}
