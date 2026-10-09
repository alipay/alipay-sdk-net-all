using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseMegagameTaskSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseMegagameTaskSyncModel : AopObject
    {
        /// <summary>
        /// 提测任务失败时需要错误信息状态码   当task_status=2时，fail_msg=0 或不填 （默认0）, 当task_status=3时，fail_msg必填且为正整数
        /// </summary>
        [XmlElement("fail_msg")]
        public long FailMsg { get; set; }

        /// <summary>
        /// 任务id，由数据库自增生成。在获取任务时给出。同步任务时作为唯一id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 提测成绩
        /// </summary>
        [XmlElement("machine_score")]
        public string MachineScore { get; set; }

        /// <summary>
        /// 任务状态码  2执行成功（默认）  3执行失败        非2  3 报错
        /// </summary>
        [XmlElement("task_status")]
        public long TaskStatus { get; set; }
    }
}
