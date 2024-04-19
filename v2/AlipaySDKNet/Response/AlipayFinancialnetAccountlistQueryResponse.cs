using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAccountlistQueryResponse.
    /// </summary>
    public class AlipayFinancialnetAccountlistQueryResponse : AopResponse
    {
        /// <summary>
        /// 账户信息
        /// </summary>
        [XmlArray("account_infos")]
        [XmlArrayItem("account_base_info_v_o")]
        public List<AccountBaseInfoVO> AccountInfos { get; set; }

        /// <summary>
        /// 示例值
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 业务处理成功
        /// </summary>
        [XmlElement("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 成功标志
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
