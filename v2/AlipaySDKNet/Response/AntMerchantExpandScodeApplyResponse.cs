using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandScodeApplyResponse.
    /// </summary>
    public class AntMerchantExpandScodeApplyResponse : AopResponse
    {
        /// <summary>
        /// apply_code_response, S码申请的结果对象
        /// </summary>
        [XmlElement("apply_code_response")]
        public ApplyCodeResponse ApplyCodeResponse { get; set; }
    }
}
