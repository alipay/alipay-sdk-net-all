using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceMindvJobsbyuserQueryResponse.
    /// </summary>
    public class AlipayIserviceMindvJobsbyuserQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户填写的任务id列表
        /// </summary>
        [XmlArray("job_ids")]
        [XmlArrayItem("number")]
        public List<long> JobIds { get; set; }
    }
}
