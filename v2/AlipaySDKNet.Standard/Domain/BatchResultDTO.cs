using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BatchResultDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BatchResultDTO : AopObject
    {
        /// <summary>
        /// 是否全部成功
        /// </summary>
        [XmlElement("all_succeeded")]
        public bool AllSucceeded { get; set; }

        /// <summary>
        /// 单一发票处理结果列表
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("single_result_d_t_o")]
        public List<SingleResultDTO> ResultList { get; set; }
    }
}
