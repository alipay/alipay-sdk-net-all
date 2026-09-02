using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorWifiShopBatchcreateResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorWifiShopBatchcreateResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("sol_wifi_shop_info")]
        public List<SolWifiShopInfo> Data { get; set; }
    }
}
