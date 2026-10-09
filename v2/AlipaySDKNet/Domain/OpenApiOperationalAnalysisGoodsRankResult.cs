using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiOperationalAnalysisGoodsRankResult Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiOperationalAnalysisGoodsRankResult : AopObject
    {
        /// <summary>
        /// 商品排行返回数据结构体
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("open_api_operation_analysis_goods_rank_alias_d_t_o")]
        public List<OpenApiOperationAnalysisGoodsRankAliasDTO> Items { get; set; }
    }
}
