using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHealthcaApplyantsignCreateResponse.
    /// </summary>
    public class AlipayCommerceMedicalHealthcaApplyantsignCreateResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("ant_sign_result_list")]
        [XmlArrayItem("ant_sign_result")]
        public List<AntSignResult> AntSignResultList { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 用印流程受理流水号
        /// </summary>
        [XmlElement("sign_flow_id")]
        public string SignFlowId { get; set; }
    }
}
