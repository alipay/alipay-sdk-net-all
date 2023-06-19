using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryVolunteersDto Data Structure.
    /// </summary>
    [Serializable]
    public class QueryVolunteersDto : AopObject
    {
        /// <summary>
        /// 活动时
        /// </summary>
        [XmlElement("hours")]
        public string Hours { get; set; }

        /// <summary>
        /// 人员ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
