using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoContractProcessDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoContractProcessDeleteModel : AopObject
    {
        /// <summary>
        /// MCCCode
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 流程Id
        /// </summary>
        [XmlArray("flow_ids")]
        [XmlArrayItem("string")]
        public List<string> FlowIds { get; set; }

        /// <summary>
        /// 签署平台的代码
        /// </summary>
        [XmlElement("sign_platform_code")]
        public string SignPlatformCode { get; set; }
    }
}
