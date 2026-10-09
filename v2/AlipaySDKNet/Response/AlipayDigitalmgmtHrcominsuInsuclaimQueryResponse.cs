using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtHrcominsuInsuclaimQueryResponse.
    /// </summary>
    public class AlipayDigitalmgmtHrcominsuInsuclaimQueryResponse : AopResponse
    {
        /// <summary>
        /// insu_claim_vos+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlArray("insu_claim_vos")]
        [XmlArrayItem("insu_claim_vo")]
        public List<InsuClaimVo> InsuClaimVos { get; set; }
    }
}
