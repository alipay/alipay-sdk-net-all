using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneFinresearchCopilotConsultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneFinresearchCopilotConsultQueryModel : AopObject
    {
        /// <summary>
        /// 咨询ID
        /// </summary>
        [XmlElement("consult_id")]
        public string ConsultId { get; set; }
    }
}
