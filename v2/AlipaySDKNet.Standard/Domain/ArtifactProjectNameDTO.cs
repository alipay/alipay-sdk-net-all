using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ArtifactProjectNameDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ArtifactProjectNameDTO : AopObject
    {
        /// <summary>
        /// 制品项目列表
        /// </summary>
        [XmlArray("artifact_project_name_list")]
        [XmlArrayItem("string")]
        public List<string> ArtifactProjectNameList { get; set; }
    }
}
