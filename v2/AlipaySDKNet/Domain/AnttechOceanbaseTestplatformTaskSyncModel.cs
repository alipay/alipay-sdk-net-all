using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseTestplatformTaskSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseTestplatformTaskSyncModel : AopObject
    {
        /// <summary>
        /// 提测时使用的代码分支
        /// </summary>
        [XmlElement("branch")]
        public string Branch { get; set; }

        /// <summary>
        /// 提测时使用的commit id
        /// </summary>
        [XmlElement("commit_id")]
        public string CommitId { get; set; }

        /// <summary>
        /// 错误信息  1branch不存在 2commit_id不存在  3 编译错误 ...
        /// </summary>
        [XmlElement("fail_msg")]
        public long FailMsg { get; set; }

        /// <summary>
        /// 提测结果类型(1:task, 2:perf)
        /// </summary>
        [XmlElement("result_type")]
        public long ResultType { get; set; }

        /// <summary>
        /// 任务id，由数据库自增生成。在获取任务时给出。同步任务时作为唯一id
        /// </summary>
        [XmlElement("task_id")]
        public long TaskId { get; set; }

        /// <summary>
        /// 任务状态码 2执行成功（默认） 3执行失败 非2 3 报错
        /// </summary>
        [XmlElement("task_status")]
        public long TaskStatus { get; set; }

        /// <summary>
        /// 用于接收所有测试结果集,当提测结果类型为1:task时用status 后台计算分数; 提测结果类型为2:pref  直接用返回的score
        /// </summary>
        [XmlElement("test_case_result")]
        public string TestCaseResult { get; set; }

        /// <summary>
        /// 题目测试时的详情、评语
        /// </summary>
        [XmlElement("test_info")]
        public string TestInfo { get; set; }
    }
}
