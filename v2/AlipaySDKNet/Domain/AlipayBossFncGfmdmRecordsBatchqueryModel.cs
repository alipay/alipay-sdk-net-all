using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfmdmRecordsBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfmdmRecordsBatchqueryModel : AopObject
    {
        /// <summary>
        /// 用于主数据项过滤指定信息的参数列表
        /// </summary>
        [XmlArray("conditions")]
        [XmlArrayItem("fv_pair_list")]
        public List<FvPairList> Conditions { get; set; }

        /// <summary>
        /// 主数据项代号
        /// </summary>
        [XmlElement("dicode")]
        public string Dicode { get; set; }
    }
}
