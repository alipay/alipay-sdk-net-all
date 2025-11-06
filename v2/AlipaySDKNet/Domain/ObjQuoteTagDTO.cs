using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ObjQuoteTagDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ObjQuoteTagDTO : AopObject
    {
        /// <summary>
        /// 标的物id
        /// </summary>
        [XmlElement("obj_id")]
        public string ObjId { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("quote_tag_d_t_o")]
        public List<QuoteTagDTO> Tags { get; set; }
    }
}
