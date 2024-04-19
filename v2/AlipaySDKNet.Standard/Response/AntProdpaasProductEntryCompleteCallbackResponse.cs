using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntProdpaasProductEntryCompleteCallbackResponse.
    /// </summary>
    public class AntProdpaasProductEntryCompleteCallbackResponse : AopResponse
    {
        /// <summary>
        /// 状态码(success|failure)
        /// </summary>
        [XmlElement("flag")]
        public string Flag { get; set; }
    }
}
