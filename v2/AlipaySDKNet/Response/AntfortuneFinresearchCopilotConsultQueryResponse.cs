using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneFinresearchCopilotConsultQueryResponse.
    /// </summary>
    public class AntfortuneFinresearchCopilotConsultQueryResponse : AopResponse
    {
        /// <summary>
        /// 咨询结果
        /// </summary>
        [XmlElement("consult_result")]
        public string ConsultResult { get; set; }
    }
}
