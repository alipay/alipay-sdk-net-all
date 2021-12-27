using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseMegagameTaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseMegagameTaskQueryModel : AopObject
    {
        /// <summary>
        /// 获取任务时先获取超时任务，这里传入的是超时的分钟数。默认30分钟。
        /// </summary>
        [XmlElement("run_task_time_out_minutes")]
        public long RunTaskTimeOutMinutes { get; set; }

        /// <summary>
        /// 参赛团队Id ，支持指定团队获取任务
        /// </summary>
        [XmlElement("team_id")]
        public string TeamId { get; set; }
    }
}
