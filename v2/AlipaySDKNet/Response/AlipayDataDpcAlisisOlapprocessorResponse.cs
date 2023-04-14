using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDpcAlisisOlapprocessorResponse.
    /// </summary>
    public class AlipayDataDpcAlisisOlapprocessorResponse : AopResponse
    {
        /// <summary>
        /// 业务处理后返回的数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
