using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysiscommodityCommodityrankingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAnalysiscommodityCommodityrankingQueryModel : AopObject
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
        /// 要查看的指标类型，访问人数Top、销量Top、支付金额Top、退款金额Top 访问人数:VISITOR_CNT 销量:SALE_CNT 支付金额:PAYMENT_AMT 退款金额:REFUND_CNT
        /// </summary>
        [XmlElement("indicator_top")]
        public string IndicatorTop { get; set; }

        /// <summary>
        /// 商品ID，查询品类指标趋势数据的主要依据
        /// </summary>
        [XmlElement("spu_id")]
        public string SpuId { get; set; }

        /// <summary>
        /// 商品名称, 在指标排行列表中查看其商品趋势数据时，如果有商品名称可以传入
        /// </summary>
        [XmlElement("spu_name")]
        public string SpuName { get; set; }

        /// <summary>
        /// 对于指标排行列表的某个品类需要查询其趋势数据，则需要设置为true,且搭配 spu_cat 、spu_cat_id、spu_name、spu_id 使用
        /// </summary>
        [XmlElement("trend")]
        public bool Trend { get; set; }
    }
}
