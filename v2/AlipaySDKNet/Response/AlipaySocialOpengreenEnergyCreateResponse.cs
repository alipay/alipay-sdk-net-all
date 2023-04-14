using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialOpengreenEnergyCreateResponse.
    /// </summary>
    public class AlipaySocialOpengreenEnergyCreateResponse : AopResponse
    {
        /// <summary>
        /// 生成能量的场景以及g数
        /// </summary>
        [XmlElement("energy_generated")]
        public string EnergyGenerated { get; set; }

        /// <summary>
        /// 失败的场景以及失败的原因
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 是否所有能量都发放成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
