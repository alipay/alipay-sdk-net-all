using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TrustStationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TrustStationInfo : AopObject
    {
        /// <summary>
        /// 站点所在场所属性
        /// </summary>
        [XmlElement("construction")]
        public string Construction { get; set; }

        /// <summary>
        /// 最大需量，单位kw
        /// </summary>
        [XmlElement("demand_load_max")]
        public string DemandLoadMax { get; set; }

        /// <summary>
        /// 用电户号
        /// </summary>
        [XmlElement("electric_account")]
        public string ElectricAccount { get; set; }

        /// <summary>
        /// 站点最大削峰能力（负荷）,单位kw
        /// </summary>
        [XmlElement("peak_shaving_load_max")]
        public string PeakShavingLoadMax { get; set; }

        /// <summary>
        /// 服务电话
        /// </summary>
        [XmlElement("service_tel")]
        public string ServiceTel { get; set; }

        /// <summary>
        /// 站点负载上限，单位kw
        /// </summary>
        [XmlElement("transformer_load_max")]
        public string TransformerLoadMax { get; set; }

        /// <summary>
        /// 站点变压器负载下限，单位kw
        /// </summary>
        [XmlElement("transformer_load_min")]
        public string TransformerLoadMin { get; set; }

        /// <summary>
        /// 最大填谷负载（能力），单位kw
        /// </summary>
        [XmlElement("valley_filling_load_max")]
        public string ValleyFillingLoadMax { get; set; }

        /// <summary>
        /// 电压等级
        /// </summary>
        [XmlElement("voltage_level")]
        public string VoltageLevel { get; set; }
    }
}
