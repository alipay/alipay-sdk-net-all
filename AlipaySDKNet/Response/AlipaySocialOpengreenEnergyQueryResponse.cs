using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialOpengreenEnergyQueryResponse.
    /// </summary>
    public class AlipaySocialOpengreenEnergyQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询所获得的能量信息
        /// </summary>
        [XmlElement("energy_info")]
        public string EnergyInfo { get; set; }

        /// <summary>
        /// 错误码，查询结果中每个场景对应的错误码信息，可能为空
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 所有场景都查询成功，即为true，否则为false
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
