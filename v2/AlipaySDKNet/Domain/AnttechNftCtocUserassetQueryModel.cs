using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftCtocUserassetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftCtocUserassetQueryModel : AopObject
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("id_no")]
        public string IdNo { get; set; }

        /// <summary>
        /// 枚举： OPEN_UID-鲸探openUid
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("sku_id_list")]
        [XmlArrayItem("number")]
        public List<long> SkuIdList { get; set; }
    }
}
