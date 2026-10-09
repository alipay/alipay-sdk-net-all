using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandIsvDeviceBindResponse.
    /// </summary>
    public class AntMerchantExpandIsvDeviceBindResponse : AopResponse
    {
        /// <summary>
        /// 申请单id
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
