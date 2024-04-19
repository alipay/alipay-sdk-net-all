using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseTestplatformTaskQueryResponse.
    /// </summary>
    public class AnttechOceanbaseTestplatformTaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 提测代码的分支
        /// </summary>
        [XmlElement("branch")]
        public string Branch { get; set; }

        /// <summary>
        /// 提测代码仓库的commit id
        /// </summary>
        [XmlElement("commit_id")]
        public string CommitId { get; set; }

        /// <summary>
        /// 当前任务的运行（重试）次数
        /// </summary>
        [XmlElement("current_retry")]
        public string CurrentRetry { get; set; }

        /// <summary>
        /// 代码仓库的url
        /// </summary>
        [XmlElement("git_repo")]
        public string GitRepo { get; set; }

        /// <summary>
        /// 任务创建的时间戳
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 参赛选手的名字
        /// </summary>
        [XmlElement("player")]
        public string Player { get; set; }

        /// <summary>
        /// 提测结果类型 默认1
        /// </summary>
        [XmlElement("result_type")]
        public long ResultType { get; set; }

        /// <summary>
        /// 测试任务的Id
        /// </summary>
        [XmlElement("task_id")]
        public long TaskId { get; set; }

        /// <summary>
        /// 二级提测题目
        /// </summary>
        [XmlElement("test_cases")]
        public string TestCases { get; set; }

        /// <summary>
        /// 测试题目
        /// </summary>
        [XmlElement("test_info")]
        public string TestInfo { get; set; }

        /// <summary>
        /// 一级提测题目
        /// </summary>
        [XmlElement("test_suite")]
        public string TestSuite { get; set; }
    }
}
