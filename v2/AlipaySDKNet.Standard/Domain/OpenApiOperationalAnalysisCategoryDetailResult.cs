using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiOperationalAnalysisCategoryDetailResult Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiOperationalAnalysisCategoryDetailResult : AopObject
    {
        /// <summary>
        /// 品类详情返回结构体
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("open_api_operation_analysis_category_detail_alias_d_t_o")]
        public List<OpenApiOperationAnalysisCategoryDetailAliasDTO> Items { get; set; }
    }
}
