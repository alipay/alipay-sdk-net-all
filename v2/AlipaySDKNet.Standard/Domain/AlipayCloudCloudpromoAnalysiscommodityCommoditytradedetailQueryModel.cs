using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysiscommodityCommoditytradedetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAnalysiscommodityCommoditytradedetailQueryModel : AopObject
    {
        /// <summary>
        /// 经营分析、经营概况模块公用入参
        /// </summary>
        [XmlElement("common_request")]
        public OpenApiAnalysisCommonRequest CommonRequest { get; set; }

        /// <summary>
        /// 品类名称, 在商品详情列表数据需要对品类名称进行筛选过滤时 可以传入此参数
        /// </summary>
        [XmlElement("spu_cat_name")]
        public string SpuCatName { get; set; }

        /// <summary>
        /// 商品ID，在商品详情列表数据中对商品ID 进行过滤和筛选
        /// </summary>
        [XmlElement("spu_id")]
        public string SpuId { get; set; }

        /// <summary>
        /// 商品名称, 在商品详情列表数据中，对商品名称进行筛选过滤。
        /// </summary>
        [XmlElement("spu_name")]
        public string SpuName { get; set; }
    }
}
