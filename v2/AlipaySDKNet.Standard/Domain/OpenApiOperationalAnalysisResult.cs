using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiOperationalAnalysisResult Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiOperationalAnalysisResult : AopObject
    {
        /// <summary>
        /// 接口返回数据
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("open_api_operation_overview_alias_d_t_o")]
        public List<OpenApiOperationOverviewAliasDTO> Items { get; set; }
    }
}
