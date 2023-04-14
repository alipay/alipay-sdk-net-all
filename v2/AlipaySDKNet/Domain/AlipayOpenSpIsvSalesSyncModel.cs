using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpIsvSalesSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpIsvSalesSyncModel : AopObject
    {
        /// <summary>
        /// 商户销售数据回传的参数对象，形式为一个列表，每天回传昨日商户的销售数据。
        /// </summary>
        [XmlArray("merchant_sales_detail")]
        [XmlArrayItem("isv_merchant_sales_detail_request")]
        public List<IsvMerchantSalesDetailRequest> MerchantSalesDetail { get; set; }
    }
}
