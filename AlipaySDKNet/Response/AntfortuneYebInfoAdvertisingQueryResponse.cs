using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneYebInfoAdvertisingQueryResponse.
    /// </summary>
    public class AntfortuneYebInfoAdvertisingQueryResponse : AopResponse
    {
        /// <summary>
        /// advertising_type：广告投放类型。  目前值为00或01。  00:表示进行投放。  01:表示不进行投放。
        /// </summary>
        [XmlElement("advertising_type")]
        public string AdvertisingType { get; set; }
    }
}
