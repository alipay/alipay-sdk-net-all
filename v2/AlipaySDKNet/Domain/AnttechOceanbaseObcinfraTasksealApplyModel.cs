using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObcinfraTasksealApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObcinfraTasksealApplyModel : AopObject
    {
        /// <summary>
        /// 部署云环境
        /// </summary>
        [XmlElement("deploy_cloud")]
        public string DeployCloud { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 环境标识
        /// </summary>
        [XmlElement("x_boss_env")]
        public string XBossEnv { get; set; }
    }
}
