using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceClaimreportVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceClaimreportVerifyModel : AopObject
    {
        /// <summary>
        /// 核对场景字段。
        /// </summary>
        [XmlElement("check_scene")]
        public string CheckScene { get; set; }

        /// <summary>
        /// 密钥，加密时使用
        /// </summary>
        [XmlElement("secret_key")]
        public string SecretKey { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("verify_param_list")]
        [XmlArrayItem("verify_param_list")]
        public List<VerifyParamList> VerifyParamList { get; set; }
    }
}
