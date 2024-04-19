using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdAntlegalchainNotaryprocsumQueryResponse.
    /// </summary>
    public class AlipayBossProdAntlegalchainNotaryprocsumQueryResponse : AopResponse
    {
        /// <summary>
        /// 法链业务ID,用于查询上链状态
        /// </summary>
        [XmlElement("bas_data_id")]
        public string BasDataId { get; set; }

        /// <summary>
        /// 操作记录列表
        /// </summary>
        [XmlArray("record_list")]
        [XmlArrayItem("query_record")]
        public List<QueryRecord> RecordList { get; set; }
    }
}
