using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneFinresearchExpertframeworkListQueryResponse.
    /// </summary>
    public class AntfortuneFinresearchExpertframeworkListQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回值里面是预设专家框架列表信息，包括了框架名称。介绍，所属的大类等信息
        /// </summary>
        [XmlElement("expert_frameworks")]
        public ZXZExpertFrameworkList ExpertFrameworks { get; set; }
    }
}
