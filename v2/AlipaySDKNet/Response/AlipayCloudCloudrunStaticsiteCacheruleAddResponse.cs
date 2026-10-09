using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunStaticsiteCacheruleAddResponse.
    /// </summary>
    public class AlipayCloudCloudrunStaticsiteCacheruleAddResponse : AopResponse
    {
        /// <summary>
        /// 缓存配置
        /// </summary>
        [XmlElement("cacherule")]
        public CacheRule Cacherule { get; set; }
    }
}
