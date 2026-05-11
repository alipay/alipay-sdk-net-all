using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRetailTaskSaveResponse.
    /// </summary>
    public class AlipayCommerceRetailTaskSaveResponse : AopResponse
    {
        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 返参列表
        /// </summary>
        [XmlElement("response_list")]
        public string ResponseList { get; set; }

        /// <summary>
        /// 任务行动类型
        /// </summary>
        [XmlElement("task_action")]
        public string TaskAction { get; set; }
    }
}
