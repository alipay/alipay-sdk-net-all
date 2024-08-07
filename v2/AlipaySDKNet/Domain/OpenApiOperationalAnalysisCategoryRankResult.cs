using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiOperationalAnalysisCategoryRankResult Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiOperationalAnalysisCategoryRankResult : AopObject
    {
        /// <summary>
        /// 品类排行数据
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("open_api_operation_analysis_category_rank_alias_d_t_o")]
        public List<OpenApiOperationAnalysisCategoryRankAliasDTO> Items { get; set; }
    }
}
