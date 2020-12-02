using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenInstantdeliveryMerchantshopModifyResponse.
    /// </summary>
    public class AlipayOpenInstantdeliveryMerchantshopModifyResponse : AopResponse
    {
        /// <summary>
        /// 门店创建返回的结果
        /// </summary>
        [XmlArray("logistics_shop_status")]
        [XmlArrayItem("logistics_shop_status_d_t_o")]
        public List<LogisticsShopStatusDTO> LogisticsShopStatus { get; set; }
    }
}
