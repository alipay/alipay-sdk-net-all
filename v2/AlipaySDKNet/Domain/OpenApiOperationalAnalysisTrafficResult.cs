using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiOperationalAnalysisTrafficResult Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiOperationalAnalysisTrafficResult : AopObject
    {
        /// <summary>
        /// 流量总览趋势数据
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("open_api_operation_analysis_traffic_alias_d_t_o")]
        public List<OpenApiOperationAnalysisTrafficAliasDTO> Items { get; set; }
    }
}
