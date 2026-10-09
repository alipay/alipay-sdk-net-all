using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunStaticsiteCacheruleBatchqueryResponse.
    /// </summary>
    public class AlipayCloudCloudrunStaticsiteCacheruleBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 缓存配置列表
        /// </summary>
        [XmlArray("cacherule_list")]
        [XmlArrayItem("cache_rule")]
        public List<CacheRule> CacheruleList { get; set; }
    }
}
