using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneHealthPrescriptionCheckResponse.
    /// </summary>
    public class AlipayInsSceneHealthPrescriptionCheckResponse : AopResponse
    {
        /// <summary>
        /// 校验详情
        /// </summary>
        [XmlArray("check_details")]
        [XmlArrayItem("prescription_check_detail")]
        public List<PrescriptionCheckDetail> CheckDetails { get; set; }

        /// <summary>
        /// 校验结果 pass:通过 need_improve:需要改进 forbidden:不通过
        /// </summary>
        [XmlElement("check_result")]
        public string CheckResult { get; set; }
    }
}
