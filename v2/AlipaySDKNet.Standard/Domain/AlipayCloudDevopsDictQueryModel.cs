using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudDevopsDictQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudDevopsDictQueryModel : AopObject
    {
        /// <summary>
        /// 任务重试黑名单列表
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
