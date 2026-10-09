using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiOperationalAnalysisTrafficPageResult Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiOperationalAnalysisTrafficPageResult : AopObject
    {
        /// <summary>
        /// 流量页面效果数据
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("open_api_operation_analysis_traffic_page_alias_d_t_o")]
        public List<OpenApiOperationAnalysisTrafficPageAliasDTO> Items { get; set; }
    }
}
