using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneInstPolicyQueryResponse.
    /// </summary>
    public class AlipayInsSceneInstPolicyQueryResponse : AopResponse
    {
        /// <summary>
        /// 电子保单下载链接
        /// </summary>
        [XmlElement("electronic_policy_url")]
        public string ElectronicPolicyUrl { get; set; }

        /// <summary>
        /// 保司保单号
        /// </summary>
        [XmlElement("inst_policy_no")]
        public string InstPolicyNo { get; set; }
    }
}
