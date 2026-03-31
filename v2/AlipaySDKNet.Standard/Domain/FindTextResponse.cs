using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FindTextResponse Data Structure.
    /// </summary>
    [Serializable]
    public class FindTextResponse : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("text_list")]
        [XmlArrayItem("find_text_d_t_o")]
        public List<FindTextDTO> TextList { get; set; }
    }
}
