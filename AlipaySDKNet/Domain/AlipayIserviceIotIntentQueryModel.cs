using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIotIntentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIotIntentQueryModel : AopObject
    {
        /// <summary>
        /// iot入参
        /// </summary>
        [XmlElement("iot_request")]
        public IntentQueryRequest IotRequest { get; set; }
    }
}
