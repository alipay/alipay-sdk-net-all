using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossBaseInstanceOperatetraceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossBaseInstanceOperatetraceQueryModel : AopObject
    {
        /// <summary>
        /// 流程实例全局唯一ID
        /// </summary>
        [XmlElement("puid")]
        public string Puid { get; set; }
    }
}
