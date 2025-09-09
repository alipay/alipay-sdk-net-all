using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseDataserviceInsighttaskQueryResponse.
    /// </summary>
    public class AnttechMorseDataserviceInsighttaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务唯一标识，标识本次查询的唯一识别号，用于链路问题定位排查和对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 任务状态:0-新建(等待中),1-已完成,2-进行中,3-运行 失败
        /// </summary>
        [XmlElement("task_status")]
        public string TaskStatus { get; set; }
    }
}
