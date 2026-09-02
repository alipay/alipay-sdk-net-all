using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMemberHealthinterpretationQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalMemberHealthinterpretationQueryResponse : AopResponse
    {
        /// <summary>
        /// 解读数据完成的手机壳
        /// </summary>
        [XmlElement("interpretation_data")]
        public string InterpretationData { get; set; }

        /// <summary>
        /// 解读状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
