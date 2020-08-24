using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishMaterialSimplifyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishMaterialSimplifyInfo : AopObject
    {
        /// <summary>
        /// 加料id列表，加料先通过加料创建接口拿到id
        /// </summary>
        [XmlArray("material_detail_list")]
        [XmlArrayItem("string")]
        public List<string> MaterialDetailList { get; set; }

        /// <summary>
        /// 加料组规格，max_count：最大可选数量，min_count：最小可选数量
        /// </summary>
        [XmlElement("material_rule")]
        public string MaterialRule { get; set; }

        /// <summary>
        /// 加料组名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
