using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RcsmartSceneContentData Data Structure.
    /// </summary>
    [Serializable]
    public class RcsmartSceneContentData : AopObject
    {
        /// <summary>
        /// 审核素材列表
        /// </summary>
        [XmlArray("audit_content_list")]
        [XmlArrayItem("rcsmart_audit_content")]
        public List<RcsmartAuditContent> AuditContentList { get; set; }

        /// <summary>
        /// 场景code
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
