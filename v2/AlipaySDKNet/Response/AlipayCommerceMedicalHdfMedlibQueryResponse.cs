using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfMedlibQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfMedlibQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回数据内容
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
