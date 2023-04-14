using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseTestplatformTaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseTestplatformTaskQueryModel : AopObject
    {
        /// <summary>
        /// 筛选结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 参赛选手的名字
        /// </summary>
        [XmlElement("palyer")]
        public string Palyer { get; set; }

        /// <summary>
        /// 允许超时任务的重试次数
        /// </summary>
        [XmlElement("run_task_retry")]
        public long RunTaskRetry { get; set; }

        /// <summary>
        /// 获取任务时先获取超时任务，这里传入的是超时的分钟数。默认30分钟。
        /// </summary>
        [XmlElement("run_task_time_out_minutes")]
        public long RunTaskTimeOutMinutes { get; set; }

        /// <summary>
        /// 获取任务的筛选条件
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 二级提测题目
        /// </summary>
        [XmlElement("test_cases")]
        public string TestCases { get; set; }

        /// <summary>
        /// 测试结果描述、备注信息
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
