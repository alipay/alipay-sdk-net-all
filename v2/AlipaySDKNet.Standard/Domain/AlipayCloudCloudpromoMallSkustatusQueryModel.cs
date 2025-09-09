using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMallSkustatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMallSkustatusQueryModel : AopObject
    {
        /// <summary>
        /// 地区码，查询商品在该区域是否可售
        /// </summary>
        [XmlElement("division_code")]
        public string DivisionCode { get; set; }

        /// <summary>
        /// 分销店铺id
        /// </summary>
        [XmlElement("purchaser_id")]
        public string PurchaserId { get; set; }

        /// <summary>
        /// sku查询请求信息
        /// </summary>
        [XmlArray("sku_query_params")]
        [XmlArrayItem("sku_query_param")]
        public List<SkuQueryParam> SkuQueryParams { get; set; }
    }
}
