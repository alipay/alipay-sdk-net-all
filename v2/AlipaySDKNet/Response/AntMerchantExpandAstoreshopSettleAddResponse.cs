using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandAstoreshopSettleAddResponse.
    /// </summary>
    public class AntMerchantExpandAstoreshopSettleAddResponse : AopResponse
    {
        /// <summary>
        /// 单据id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
