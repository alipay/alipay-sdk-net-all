using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEngineeringInfrastructureAnttestopsTestcaseTriggerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEngineeringInfrastructureAnttestopsTestcaseTriggerModel : AopObject
    {
        /// <summary>
        /// 操作者阿里花名，若是外包：张三(WB123)
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 执行环境
        /// </summary>
        [XmlElement("env_enum")]
        public string EnvEnum { get; set; }

        /// <summary>
        /// 来源应用英文名-aone查看
        /// </summary>
        [XmlElement("original_system")]
        public string OriginalSystem { get; set; }

        /// <summary>
        /// 场景数据
        /// </summary>
        [XmlElement("scene_data")]
        public SceneData SceneData { get; set; }

        /// <summary>
        /// 场景数据ID
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 联调分组
        /// </summary>
        [XmlElement("sofa_group")]
        public string SofaGroup { get; set; }

        /// <summary>
        /// 用例ID，蚂蚁业务侧对外提供
        /// </summary>
        [XmlElement("test_case_id")]
        public string TestCaseId { get; set; }
    }
}
