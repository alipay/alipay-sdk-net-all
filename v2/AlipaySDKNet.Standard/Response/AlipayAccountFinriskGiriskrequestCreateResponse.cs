using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAccountFinriskGiriskrequestCreateResponse.
    /// </summary>
    public class AlipayAccountFinriskGiriskrequestCreateResponse : AopResponse
    {
        /// <summary>
        /// 二代结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 三代结果码
        /// </summary>
        [XmlElement("result_code_third")]
        public string ResultCodeThird { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [XmlElement("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 风险信息明细
        /// </summary>
        [XmlArray("risk_details")]
        [XmlArrayItem("entity_prior_risk_v_o")]
        public List<EntityPriorRiskVO> RiskDetails { get; set; }

        /// <summary>
        /// 风险认证结果码
        /// </summary>
        [XmlElement("risk_result_code")]
        public string RiskResultCode { get; set; }

        /// <summary>
        /// 是否业务处理成功。 true：处理成功；false：处理失败。 默认：false
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
