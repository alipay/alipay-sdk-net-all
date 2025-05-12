using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResponseObjManjiangTest Data Structure.
    /// </summary>
    [Serializable]
    public class ResponseObjManjiangTest : AopObject
    {
        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("repsponse_id_json")]
        public string RepsponseIdJson { get; set; }
    }
}
