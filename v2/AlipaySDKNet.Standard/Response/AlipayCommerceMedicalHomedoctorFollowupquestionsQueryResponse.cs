using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHomedoctorFollowupquestionsQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHomedoctorFollowupquestionsQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("question_list")]
        [XmlArrayItem("question_info_openapi_response")]
        public List<QuestionInfoOpenapiResponse> QuestionList { get; set; }
    }
}
