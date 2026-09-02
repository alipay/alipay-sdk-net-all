using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SaveRecordDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SaveRecordDTO : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("fields")]
        [XmlArrayItem("field_info_d_t_o")]
        public List<FieldInfoDTO> Fields { get; set; }
    }
}
