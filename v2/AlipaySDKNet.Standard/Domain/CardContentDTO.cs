using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardContentDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CardContentDTO : AopObject
    {
        /// <summary>
        /// 卡片列表
        /// </summary>
        [XmlArray("card_list")]
        [XmlArrayItem("card_unit")]
        public List<CardUnit> CardList { get; set; }

        /// <summary>
        /// 扩展数据
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }
    }
}
