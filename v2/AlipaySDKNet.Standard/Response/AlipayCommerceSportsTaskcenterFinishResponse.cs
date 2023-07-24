using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceSportsTaskcenterFinishResponse.
    /// </summary>
    public class AlipayCommerceSportsTaskcenterFinishResponse : AopResponse
    {
        /// <summary>
        /// 用户任务
        /// </summary>
        [XmlElement("user_task")]
        public UserTaskSimpleDto UserTask { get; set; }
    }
}
