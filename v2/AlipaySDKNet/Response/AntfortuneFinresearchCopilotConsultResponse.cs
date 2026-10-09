using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneFinresearchCopilotConsultResponse.
    /// </summary>
    public class AntfortuneFinresearchCopilotConsultResponse : AopResponse
    {
        /// <summary>
        /// 咨询ID
        /// </summary>
        [XmlElement("consult_id")]
        public string ConsultId { get; set; }
    }
}
