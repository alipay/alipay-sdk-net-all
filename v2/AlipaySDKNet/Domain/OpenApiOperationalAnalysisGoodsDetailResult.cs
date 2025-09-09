using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiOperationalAnalysisGoodsDetailResult Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiOperationalAnalysisGoodsDetailResult : AopObject
    {
        /// <summary>
        /// 商品详情返回结构体
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("open_api_operation_analysis_goods_detail_alias_d_t_o")]
        public List<OpenApiOperationAnalysisGoodsDetailAliasDTO> Items { get; set; }
    }
}
