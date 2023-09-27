using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskOperateResult Data Structure.
    /// </summary>
    [Serializable]
    public class TaskOperateResult : AopObject
    {
        /// <summary>
        /// 创建任务失败，异常信息为xx
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 是否需要告警，当 istrue为false且needWarning为true才会告警， 当istrue为false且needWarning为false则为系统正常校验，不需要告警，只需要将errorMessage展示出来 needWarning默认为true
        /// </summary>
        [XmlElement("need_warning")]
        public bool NeedWarning { get; set; }

        /// <summary>
        /// 返回结果，成功/失败
        /// </summary>
        [XmlElement("task_operate_result")]
        public bool TaskOperateResult_ { get; set; }
    }
}
