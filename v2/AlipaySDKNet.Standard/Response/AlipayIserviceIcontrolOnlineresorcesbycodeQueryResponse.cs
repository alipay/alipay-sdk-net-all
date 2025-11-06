using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIcontrolOnlineresorcesbycodeQueryResponse.
    /// </summary>
    public class AlipayIserviceIcontrolOnlineresorcesbycodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回的结果
        /// </summary>
        [XmlArray("resources")]
        [XmlArrayItem("available_resource_model")]
        public List<AvailableResourceModel> Resources { get; set; }
    }
}
