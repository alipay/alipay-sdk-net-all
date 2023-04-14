using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandScodeApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandScodeApplyModel : AopObject
    {
        /// <summary>
        /// apply_code_request，申请S码的请求参数
        /// </summary>
        [XmlArray("apply_code_request")]
        [XmlArrayItem("apply_code_request")]
        public List<ApplyCodeRequest> ApplyCodeRequest { get; set; }
    }
}
