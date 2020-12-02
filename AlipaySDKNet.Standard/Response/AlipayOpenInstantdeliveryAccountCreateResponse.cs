using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenInstantdeliveryAccountCreateResponse.
    /// </summary>
    public class AlipayOpenInstantdeliveryAccountCreateResponse : AopResponse
    {
        /// <summary>
        /// 配送公司账户创建结果列表
        /// </summary>
        [XmlArray("logistics_account_status")]
        [XmlArrayItem("logistics_account_status_d_t_o")]
        public List<LogisticsAccountStatusDTO> LogisticsAccountStatus { get; set; }
    }
}
