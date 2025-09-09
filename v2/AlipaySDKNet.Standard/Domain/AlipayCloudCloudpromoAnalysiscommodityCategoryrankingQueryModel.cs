using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysiscommodityCategoryrankingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAnalysiscommodityCategoryrankingQueryModel : AopObject
    {
        /// <summary>
        /// 品类ID，查询品类指标趋势数据的主要依据
        /// </summary>
        [XmlElement("cate_id")]
        public string CateId { get; set; }

        /// <summary>
        /// 品类名称, 在指标排行列表中查看其品类趋势数据时，如果有品类名称可以传入
        /// </summary>
        [XmlElement("cate_name")]
        public string CateName { get; set; }

        /// <summary>
        /// 经营分析、经营概况模块公用入参
        /// </summary>
        [XmlElement("common_request")]
        public OpenApiAnalysisCommonRequest CommonRequest { get; set; }

        /// <summary>
        /// 目前仅支持品类、商品排行模块使用
        /// </summary>
        [XmlElement("indicator_top")]
        public string IndicatorTop { get; set; }

        /// <summary>
        /// 对于指标排行列表的某个品类需要查询其趋势数据，则需要设置为true,且搭配 spu_cat 和spu_cat_id使用
        /// </summary>
        [XmlElement("trend")]
        public bool Trend { get; set; }
    }
}
