using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiCustomerAnalysisTradeLevelResult Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiCustomerAnalysisTradeLevelResult : AopObject
    {
        /// <summary>
        /// 消费层级返回结构体
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("open_api_operation_analysis_customer_trd_lvl_alias_d_t_o")]
        public List<OpenApiOperationAnalysisCustomerTrdLvlAliasDTO> Items { get; set; }
    }
}
