using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntProdpaasProductExitCompleteCallbackResponse.
    /// </summary>
    public class AntProdpaasProductExitCompleteCallbackResponse : AopResponse
    {
        /// <summary>
        /// 状态码(success|failure)
        /// </summary>
        [XmlElement("flag")]
        public string Flag { get; set; }
    }
}
