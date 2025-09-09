using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMallSkustatusQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMallSkustatusQueryResponse : AopResponse
    {
        /// <summary>
        /// sku售卖信息
        /// </summary>
        [XmlArray("sku_sale_infos")]
        [XmlArrayItem("sku_sale_info_v_o")]
        public List<SkuSaleInfoVO> SkuSaleInfos { get; set; }
    }
}
