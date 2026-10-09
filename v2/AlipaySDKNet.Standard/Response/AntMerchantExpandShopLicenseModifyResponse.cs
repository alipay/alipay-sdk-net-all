using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandShopLicenseModifyResponse.
    /// </summary>
    public class AntMerchantExpandShopLicenseModifyResponse : AopResponse
    {
        /// <summary>
        /// 2018011900502000000005124744
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
