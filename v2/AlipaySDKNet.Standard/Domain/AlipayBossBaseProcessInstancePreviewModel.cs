using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossBaseProcessInstancePreviewModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossBaseProcessInstancePreviewModel : AopObject
    {
        /// <summary>
        /// 流程实例Id
        /// </summary>
        [XmlElement("puid")]
        public string Puid { get; set; }
    }
}
