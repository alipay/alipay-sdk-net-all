using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMallItemstatusQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMallItemstatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品售卖信息
        /// </summary>
        [XmlArray("product_sale_infos")]
        [XmlArrayItem("product_sale_info_v_o")]
        public List<ProductSaleInfoVO> ProductSaleInfos { get; set; }
    }
}
