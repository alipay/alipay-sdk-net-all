using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMallItemstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMallItemstatusQueryModel : AopObject
    {
        /// <summary>
        /// 地区码，查询商品在该区域是否可售。
        /// </summary>
        [XmlElement("division_code")]
        public string DivisionCode { get; set; }

        /// <summary>
        /// 商品id列表
        /// </summary>
        [XmlArray("product_ids")]
        [XmlArrayItem("string")]
        public List<string> ProductIds { get; set; }

        /// <summary>
        /// 分销店铺id
        /// </summary>
        [XmlElement("purchaser_id")]
        public string PurchaserId { get; set; }
    }
}
