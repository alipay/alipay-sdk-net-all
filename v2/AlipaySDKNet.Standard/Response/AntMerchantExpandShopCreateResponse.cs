using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandShopCreateResponse.
    /// </summary>
    public class AntMerchantExpandShopCreateResponse : AopResponse
    {
        /// <summary>
        /// 触发幂等时返回已存在的门店shopId
        /// </summary>
        [XmlElement("exist_shop_id")]
        public string ExistShopId { get; set; }

        /// <summary>
        /// 申请单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
