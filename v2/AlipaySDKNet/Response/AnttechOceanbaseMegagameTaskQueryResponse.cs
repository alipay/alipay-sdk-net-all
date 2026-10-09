using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseMegagameTaskQueryResponse.
    /// </summary>
    public class AnttechOceanbaseMegagameTaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 参赛选手的提测代码分支，推荐用master。支持自定义
        /// </summary>
        [XmlElement("branch")]
        public string Branch { get; set; }

        /// <summary>
        /// git 中commit id
        /// </summary>
        [XmlElement("commit_id")]
        public string CommitId { get; set; }

        /// <summary>
        /// 参赛选手的git 代码仓库地址
        /// </summary>
        [XmlElement("git_repo")]
        public string GitRepo { get; set; }

        /// <summary>
        /// 提测任务id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 团队表中的自增主键id
        /// </summary>
        [XmlElement("team_id")]
        public long TeamId { get; set; }
    }
}
