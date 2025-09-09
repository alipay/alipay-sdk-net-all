using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeBatchFinishQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeBatchFinishQueryModel : AopObject
    {
        /// <summary>
        /// 关账的汇总信息查询基础模型，其中batch_id非空
        /// </summary>
        [XmlArray("query_info_list")]
        [XmlArrayItem("batch_finish_query_info")]
        public List<BatchFinishQueryInfo> QueryInfoList { get; set; }
    }
}
