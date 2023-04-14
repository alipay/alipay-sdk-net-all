using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubTaskInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SubTaskInfo : AopObject
    {
        /// <summary>
        /// 子任务执行结果；执行成功为成功，失败则填充失败结果
        /// </summary>
        [XmlElement("execute_result")]
        public string ExecuteResult { get; set; }

        /// <summary>
        /// 子任务状态 状态 INIT:初始化 FAILURE:失败 SUCCESS:成功
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子任务类型 SIGN_TASK：签约子任务 OPE_TASK：代运营授权子任务 APP_TASK：应用授权子任务
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 子任务类型描述
        /// </summary>
        [XmlElement("type_desc")]
        public string TypeDesc { get; set; }
    }
}
