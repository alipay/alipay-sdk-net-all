using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleDeliveryConfigDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleDeliveryConfigDTO : AopObject
    {
        /// <summary>
        /// 履约价格
        /// </summary>
        [XmlElement("delivery_price")]
        public RecycleDeliveryPriceDTO DeliveryPrice { get; set; }

        /// <summary>
        /// 中国省份编码，110000 代表北京，310000代表上海
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }
    }
}
