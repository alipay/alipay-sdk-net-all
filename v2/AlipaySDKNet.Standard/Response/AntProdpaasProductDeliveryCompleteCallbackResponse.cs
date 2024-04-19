using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntProdpaasProductDeliveryCompleteCallbackResponse.
    /// </summary>
    public class AntProdpaasProductDeliveryCompleteCallbackResponse : AopResponse
    {
        /// <summary>
        /// 状态码(success|failure)
        /// </summary>
        [XmlElement("flag")]
        public string Flag { get; set; }
    }
}
