using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowShakecodeCreateResponse.
    /// </summary>
    public class AlipayCommerceLogisticsFreightflowShakecodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 生成的吱口令完整文案
        /// </summary>
        [XmlElement("shake_code_text")]
        public string ShakeCodeText { get; set; }
    }
}
