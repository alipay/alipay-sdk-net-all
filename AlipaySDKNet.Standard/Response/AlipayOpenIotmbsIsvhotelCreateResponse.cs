using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotmbsIsvhotelCreateResponse.
    /// </summary>
    public class AlipayOpenIotmbsIsvhotelCreateResponse : AopResponse
    {
        /// <summary>
        /// project_id+需要编辑的酒店id
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }
    }
}
