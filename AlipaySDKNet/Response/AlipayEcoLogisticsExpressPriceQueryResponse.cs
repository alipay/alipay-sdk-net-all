using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoLogisticsExpressPriceQueryResponse.
    /// </summary>
    public class AlipayEcoLogisticsExpressPriceQueryResponse : AopResponse
    {
        /// <summary>
        /// 续重价格（单位：元）
        /// </summary>
        [XmlElement("extra_weight_price")]
        public string ExtraWeightPrice { get; set; }

        /// <summary>
        /// 续重单位（单位：克）
        /// </summary>
        [XmlElement("extra_weight_unit")]
        public long ExtraWeightUnit { get; set; }

        /// <summary>
        /// 首重重量（单位：克）
        /// </summary>
        [XmlElement("preset_weight")]
        public long PresetWeight { get; set; }

        /// <summary>
        /// 首重价格（单位：元）
        /// </summary>
        [XmlElement("preset_weight_price")]
        public string PresetWeightPrice { get; set; }
    }
}
