using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseBcClusterQueryResponse.
    /// </summary>
    public class AlipaySocialBaseBcClusterQueryResponse : AopResponse
    {
        /// <summary>
        /// 分组数据详情
        /// </summary>
        [XmlArray("cluster_details")]
        [XmlArrayItem("bc_group_cluster_detail")]
        public List<BcGroupClusterDetail> ClusterDetails { get; set; }
    }
}
