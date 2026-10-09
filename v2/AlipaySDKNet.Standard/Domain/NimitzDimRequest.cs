using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NimitzDimRequest Data Structure.
    /// </summary>
    [Serializable]
    public class NimitzDimRequest : AopObject
    {
        /// <summary>
        /// 返回字段
        /// </summary>
        [XmlArray("fields")]
        [XmlArrayItem("string")]
        public List<string> Fields { get; set; }

        /// <summary>
        /// KV检索，类比sql语句where条件中的in
        /// </summary>
        [XmlArray("kv_attributes")]
        [XmlArrayItem("k_v_obj")]
        public List<KVObj> KvAttributes { get; set; }

        /// <summary>
        /// 分页条件
        /// </summary>
        [XmlElement("page_cond")]
        public NimitzPageCond PageCond { get; set; }

        /// <summary>
        /// 区间检索，类比于sql语句where条件中的between and
        /// </summary>
        [XmlArray("range_attributes")]
        [XmlArrayItem("nimitz_range_cond")]
        public List<NimitzRangeCond> RangeAttributes { get; set; }

        /// <summary>
        /// dim和dataset均称之为rsData，dim以DM_开头，dataset以DS_开头
        /// </summary>
        [XmlElement("rs_dataset")]
        public string RsDataset { get; set; }
    }
}
