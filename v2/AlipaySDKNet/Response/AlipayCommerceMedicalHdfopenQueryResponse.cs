using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfopenQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfopenQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回参数
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
