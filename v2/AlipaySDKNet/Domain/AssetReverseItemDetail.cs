using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetReverseItemDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AssetReverseItemDetail : AopObject
    {
        /// <summary>
        /// 申请数量，如1
        /// </summary>
        [XmlElement("count")]
        public string Count { get; set; }

        /// <summary>
        /// 发起未妥投的物料id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 本次未妥投对应列表
        /// </summary>
        [XmlArray("sn_records")]
        [XmlArrayItem("string")]
        public List<string> SnRecords { get; set; }
    }
}
