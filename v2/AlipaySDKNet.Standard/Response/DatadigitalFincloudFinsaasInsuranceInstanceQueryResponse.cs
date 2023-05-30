using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasInsuranceInstanceQueryResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasInsuranceInstanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 实例列表
        /// </summary>
        [XmlArray("instance_list")]
        [XmlArrayItem("instance_v_o")]
        public List<InstanceVO> InstanceList { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }
    }
}
