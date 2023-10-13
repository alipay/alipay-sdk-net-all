using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiAuthAmountInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiAuthAmountInfoDTO : AopObject
    {
        /// <summary>
        /// 授权金额信息
        /// </summary>
        [XmlArray("amounts")]
        [XmlArrayItem("open_api_auth_amount_d_t_o")]
        public List<OpenApiAuthAmountDTO> Amounts { get; set; }

        /// <summary>
        /// 过授权规则包查询，命中的规则编码.
        /// </summary>
        [XmlElement("rule_code")]
        public string RuleCode { get; set; }

        /// <summary>
        /// 通过授权规则包查询，命中的规则名称
        /// </summary>
        [XmlElement("rule_name")]
        public string RuleName { get; set; }
    }
}
