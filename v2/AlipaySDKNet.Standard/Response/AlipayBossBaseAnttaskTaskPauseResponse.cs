using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossBaseAnttaskTaskPauseResponse.
    /// </summary>
    public class AlipayBossBaseAnttaskTaskPauseResponse : AopResponse
    {
        /// <summary>
        /// 失败才会返回信息
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 是否需要告警，当 istrue为false且needWarning为true才会告警， 当istrue为false且needWarning为false则为系统正常校验，不需要告警，只需要将errorMessage展示出来 needWarning默认为true
        /// </summary>
        [XmlElement("need_warning")]
        public bool NeedWarning { get; set; }

        /// <summary>
        /// 暂时无使用
        /// </summary>
        [XmlElement("task_error_code")]
        public string TaskErrorCode { get; set; }

        /// <summary>
        /// 任务操作结果
        /// </summary>
        [XmlElement("task_operate_result")]
        public bool TaskOperateResult { get; set; }
    }
}
