using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneFinresearchModelConsultResponse.
    /// </summary>
    public class AntfortuneFinresearchModelConsultResponse : AopResponse
    {
        /// <summary>
        /// 模型的返回结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
