using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTravelAccountMktaccountQueryResponse.
    /// </summary>
    public class AlipayOverseasTravelAccountMktaccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否需要重试
        /// </summary>
        [XmlElement("need_retry")]
        public bool NeedRetry { get; set; }

        /// <summary>
        /// 外部营销账号列表
        /// </summary>
        [XmlArray("out_mkt_accounts")]
        [XmlArrayItem("out_mkt_account")]
        public List<OutMktAccount> OutMktAccounts { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [XmlElement("result_message")]
        public string ResultMessage { get; set; }

        /// <summary>
        /// 结果状态
        /// </summary>
        [XmlElement("result_status")]
        public string ResultStatus { get; set; }
    }
}
