using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageCacheruleAddResponse.
    /// </summary>
    public class AlipayCloudCloudrunObjectstorageCacheruleAddResponse : AopResponse
    {
        /// <summary>
        /// 缓存规则
        /// </summary>
        [XmlElement("cacherule")]
        public CacheRule Cacherule { get; set; }
    }
}
