using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossBaseFrastressQueryriskdomainQueryResponse.
    /// </summary>
    public class AlipayBossBaseFrastressQueryriskdomainQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回实体结果
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("risk_biz_domain")]
        public List<RiskBizDomain> Result { get; set; }
    }
}
