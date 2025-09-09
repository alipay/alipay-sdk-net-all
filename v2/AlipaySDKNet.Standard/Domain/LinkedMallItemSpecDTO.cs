using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LinkedMallItemSpecDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LinkedMallItemSpecDTO : AopObject
    {
        /// <summary>
        /// 规格名
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 规格值集合
        /// </summary>
        [XmlArray("values")]
        [XmlArrayItem("linked_mall_item_spec_value_d_t_o")]
        public List<LinkedMallItemSpecValueDTO> Values { get; set; }
    }
}
