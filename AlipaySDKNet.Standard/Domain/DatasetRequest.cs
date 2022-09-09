using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatasetRequest Data Structure.
    /// </summary>
    [Serializable]
    public class DatasetRequest : AopObject
    {
        /// <summary>
        /// 返回字段
        /// </summary>
        [XmlArray("fields")]
        [XmlArrayItem("string")]
        public List<string> Fields { get; set; }

        /// <summary>
        /// 普通维度
        /// </summary>
        [XmlArray("individual_dim_keys")]
        [XmlArrayItem("k_v_obj")]
        public List<KVObj> IndividualDimKeys { get; set; }

        /// <summary>
        /// obj维度，业务层面定义，产品编码
        /// </summary>
        [XmlArray("obj_dim_keys")]
        [XmlArrayItem("string")]
        public List<string> ObjDimKeys { get; set; }

        /// <summary>
        /// 分页条件
        /// </summary>
        [XmlElement("page_cond")]
        public NimitzPageCond PageCond { get; set; }

        /// <summary>
        /// 时序维度
        /// </summary>
        [XmlElement("range_cond")]
        public NimitzRangeCond RangeCond { get; set; }

        /// <summary>
        /// 是否逆序
        /// </summary>
        [XmlElement("reversed")]
        public bool Reversed { get; set; }

        /// <summary>
        /// 全局唯一 table数据标识，这里代表dataSet，以DS_开头
        /// </summary>
        [XmlElement("rs_dataset")]
        public string RsDataset { get; set; }
    }
}
