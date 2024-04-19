using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChargeRelationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ChargeRelationInfo : AopObject
    {
        /// <summary>
        /// 关联主ID
        /// </summary>
        [XmlElement("primary_id")]
        public string PrimaryId { get; set; }

        /// <summary>
        /// 关联子ID
        /// </summary>
        [XmlElement("slave_id")]
        public string SlaveId { get; set; }
    }
}
