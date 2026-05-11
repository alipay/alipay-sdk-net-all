using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalExaminationCategorylistQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalExaminationCategorylistQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("category_info_list")]
        [XmlArrayItem("examination_category_info")]
        public List<ExaminationCategoryInfo> CategoryInfoList { get; set; }
    }
}
