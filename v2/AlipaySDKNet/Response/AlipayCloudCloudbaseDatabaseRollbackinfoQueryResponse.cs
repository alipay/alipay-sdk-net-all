using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseDatabaseRollbackinfoQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseDatabaseRollbackinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 可回档列表
        /// </summary>
        [XmlArray("rollback_infos")]
        [XmlArrayItem("mongo_rollback_info")]
        public List<MongoRollbackInfo> RollbackInfos { get; set; }
    }
}
