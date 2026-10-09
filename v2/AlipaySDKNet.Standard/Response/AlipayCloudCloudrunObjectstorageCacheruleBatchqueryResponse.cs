using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageCacheruleBatchqueryResponse.
    /// </summary>
    public class AlipayCloudCloudrunObjectstorageCacheruleBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 缓存列表
        /// </summary>
        [XmlArray("cacherule_list")]
        [XmlArrayItem("cache_rule")]
        public List<CacheRule> CacheruleList { get; set; }
    }
}
