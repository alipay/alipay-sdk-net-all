using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdRisktaskFinishinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdRisktaskFinishinfoQueryModel : AopObject
    {
        /// <summary>
        /// task_id_list 查询指定taskId列表
        /// </summary>
        [XmlArray("task_id_list")]
        [XmlArrayItem("string")]
        public List<string> TaskIdList { get; set; }
    }
}
