using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaOpenKaifangKaifangQueryResponse.
    /// </summary>
    public class ZhimaOpenKaifangKaifangQueryResponse : AopResponse
    {
        /// <summary>
        /// 555
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }
    }
}
