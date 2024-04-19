using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalopUcdpApecreativeGroupQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalopUcdpApecreativeGroupQueryModel : AopObject
    {
        /// <summary>
        /// 商家在蚂蚁推荐引擎创建的项目id，调用前需要找蚂蚁技术获取。
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }
    }
}
