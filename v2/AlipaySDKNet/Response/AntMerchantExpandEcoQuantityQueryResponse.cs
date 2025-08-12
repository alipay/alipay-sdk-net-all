using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandEcoQuantityQueryResponse.
    /// </summary>
    public class AntMerchantExpandEcoQuantityQueryResponse : AopResponse
    {
        /// <summary>
        /// 生态供应商订单数量明细，从入参年月日期初到月末的集合
        /// </summary>
        [XmlArray("eco_order_quantity")]
        [XmlArrayItem("asset_eco_order_quantity")]
        public List<AssetEcoOrderQuantity> EcoOrderQuantity { get; set; }
    }
}
