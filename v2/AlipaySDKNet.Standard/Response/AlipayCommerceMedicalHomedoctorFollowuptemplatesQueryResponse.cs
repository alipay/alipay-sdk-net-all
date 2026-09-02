using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHomedoctorFollowuptemplatesQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHomedoctorFollowuptemplatesQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("template_list")]
        [XmlArrayItem("template_info_response")]
        public List<TemplateInfoResponse> TemplateList { get; set; }
    }
}
