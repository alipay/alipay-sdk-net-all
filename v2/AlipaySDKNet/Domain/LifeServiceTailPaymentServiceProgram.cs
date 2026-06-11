using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LifeServiceTailPaymentServiceProgram Data Structure.
    /// </summary>
    [Serializable]
    public class LifeServiceTailPaymentServiceProgram : AopObject
    {
        /// <summary>
        /// 服务项目的数量
        /// </summary>
        [XmlElement("service_program_count")]
        public long ServiceProgramCount { get; set; }

        /// <summary>
        /// 服务项目的具体明细
        /// </summary>
        [XmlElement("service_program_name")]
        public string ServiceProgramName { get; set; }

        /// <summary>
        /// 服务项目费用
        /// </summary>
        [XmlElement("service_program_unit_price_yuan")]
        public string ServiceProgramUnitPriceYuan { get; set; }
    }
}
