using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfarmProjectInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AntfarmProjectInfo : AopObject
    {
        /// <summary>
        /// 捐赠项目 id
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 捐赠项目名称
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }

        /// <summary>
        /// 当前项目下标的物列表
        /// </summary>
        [XmlArray("target_list")]
        [XmlArrayItem("antfarm_project_target_info")]
        public List<AntfarmProjectTargetInfo> TargetList { get; set; }
    }
}
