using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiRetailTopinstanceQueryResponse.
    /// </summary>
    public class KoubeiRetailTopinstanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 商户维度券或者DM信息列表
        /// </summary>
        [XmlArray("instance_list")]
        [XmlArrayItem("instance_info")]
        public List<InstanceInfo> InstanceList { get; set; }

        /// <summary>
        /// 返回的总记录数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
