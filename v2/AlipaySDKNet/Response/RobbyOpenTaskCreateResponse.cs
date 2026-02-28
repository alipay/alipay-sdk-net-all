using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// RobbyOpenTaskCreateResponse.
    /// </summary>
    public class RobbyOpenTaskCreateResponse : AopResponse
    {
        /// <summary>
        /// 业务编号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        ///  子业务编号
        /// </summary>
        [XmlElement("sub_biz_no")]
        public string SubBizNo { get; set; }

        /// <summary>
        /// 灵波任务指令编号，仅任务状态成功fan'hu
        /// </summary>
        [XmlElement("task_no")]
        public string TaskNo { get; set; }

        /// <summary>
        /// 任务接收状态，具体查看枚举值
        /// </summary>
        [XmlElement("task_status")]
        public string TaskStatus { get; set; }
    }
}
