using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseBcClustermsgQueryResponse.
    /// </summary>
    public class AlipaySocialBaseBcClustermsgQueryResponse : AopResponse
    {
        /// <summary>
        /// 消息记录
        /// </summary>
        [XmlArray("msg_records")]
        [XmlArrayItem("bc_cluster_msg_record")]
        public List<BcClusterMsgRecord> MsgRecords { get; set; }
    }
}
