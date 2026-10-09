using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryAvailableScope Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryAvailableScope : AopObject
    {
        /// <summary>
        /// 投放城市编码，当delivery_available_scope_type=CITY_CODE，那么该对象必须填值。填值时all_city和city_codes两者二选一且必填。
        /// </summary>
        [XmlElement("delivery_available_city_code")]
        public DeliveryAvailableCityCode DeliveryAvailableCityCode { get; set; }

        /// <summary>
        /// 投放可用范围类型，目前支持的类型是城市范围CITY_CODE
        /// </summary>
        [XmlElement("delivery_available_scope_type")]
        public string DeliveryAvailableScopeType { get; set; }
    }
}
