using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseSubaccountApplyResponse.
    /// </summary>
    public class AnttechOceanbaseSubaccountApplyResponse : AopResponse
    {
        /// <summary>
        /// 财资子户申请结果返回结果
        /// </summary>
        [XmlElement("sub_account_apply_result")]
        public SubAccountApplyResult SubAccountApplyResult { get; set; }
    }
}
