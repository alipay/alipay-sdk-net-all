using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleCharityProjectTest Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleCharityProjectTest : AopObject
    {
        /// <summary>
        /// 1111
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }
    }
}
