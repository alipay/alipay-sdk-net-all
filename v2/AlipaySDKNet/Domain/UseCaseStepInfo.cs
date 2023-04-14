using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UseCaseStepInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UseCaseStepInfo : AopObject
    {
        /// <summary>
        /// 方法描述
        /// </summary>
        [XmlElement("method_desc")]
        public string MethodDesc { get; set; }

        /// <summary>
        /// 功能方法名(固定的那几种)
        /// </summary>
        [XmlElement("method_name")]
        public string MethodName { get; set; }

        /// <summary>
        /// 操作动作或业务分类,(固定的12种)
        /// </summary>
        [XmlElement("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 参数列表
        /// </summary>
        [XmlArray("param_info_list")]
        [XmlArrayItem("serve_param_info")]
        public List<ServeParamInfo> ParamInfoList { get; set; }

        /// <summary>
        /// 步骤前置条件
        /// </summary>
        [XmlArray("precondition_list")]
        [XmlArrayItem("precondition")]
        public List<Precondition> PreconditionList { get; set; }

        /// <summary>
        /// 结果返回值
        /// </summary>
        [XmlElement("response_data")]
        public string ResponseData { get; set; }

        /// <summary>
        /// 操作步骤备注
        /// </summary>
        [XmlElement("step_note")]
        public string StepNote { get; set; }

        /// <summary>
        /// 服务类
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
