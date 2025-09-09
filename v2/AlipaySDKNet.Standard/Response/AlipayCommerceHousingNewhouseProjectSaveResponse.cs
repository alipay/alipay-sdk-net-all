using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceHousingNewhouseProjectSaveResponse.
    /// </summary>
    public class AlipayCommerceHousingNewhouseProjectSaveResponse : AopResponse
    {
        /// <summary>
        /// 楼盘id
        /// </summary>
        [XmlElement("estate_project_id")]
        public string EstateProjectId { get; set; }
    }
}
