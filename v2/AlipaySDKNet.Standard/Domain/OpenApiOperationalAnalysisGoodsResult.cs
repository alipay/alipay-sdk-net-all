using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiOperationalAnalysisGoodsResult Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiOperationalAnalysisGoodsResult : AopObject
    {
        /// <summary>
        /// 商品总览趋势数据
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("open_api_operation_analysis_goods_alias_d_t_o")]
        public List<OpenApiOperationAnalysisGoodsAliasDTO> Items { get; set; }
    }
}
