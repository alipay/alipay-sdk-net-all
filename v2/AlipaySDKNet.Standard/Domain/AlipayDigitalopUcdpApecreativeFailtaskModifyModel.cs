using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalopUcdpApecreativeFailtaskModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalopUcdpApecreativeFailtaskModifyModel : AopObject
    {
        /// <summary>
        /// ape创意组id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 商家在蚂蚁推荐引擎创建的项目id，调用前需要找蚂蚁技术获取。
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }
    }
}
