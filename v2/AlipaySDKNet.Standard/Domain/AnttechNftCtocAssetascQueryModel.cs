using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftCtocAssetascQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftCtocAssetascQueryModel : AopObject
    {
        /// <summary>
        /// 接入tocken
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 鲸探openUid
        /// </summary>
        [XmlElement("id_no")]
        public string IdNo { get; set; }

        /// <summary>
        /// 枚举： OPEN_UID-鲸探openUid
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 上次的最后一条数据游标id  当前字段已废弃(namber无法满足现在的业务需求)
        /// </summary>
        [XmlElement("last_index")]
        public long LastIndex { get; set; }

        /// <summary>
        /// 上次的最后一条数据游标id的string
        /// </summary>
        [XmlElement("last_index_str")]
        public string LastIndexStr { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("sku_id_list")]
        [XmlArrayItem("number")]
        public List<long> SkuIdList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("sku_id_list_str")]
        [XmlArrayItem("string")]
        public List<string> SkuIdListStr { get; set; }
    }
}
