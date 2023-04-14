using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeServiceSignQueryResponse.
    /// </summary>
    public class AlipayTradeServiceSignQueryResponse : AopResponse
    {
        /// <summary>
        /// 如果协议未签约时，会返回协议文本对应的标题和URL
        /// </summary>
        [XmlArray("agreement_text_infos")]
        [XmlArrayItem("agreement_text_info")]
        public List<AgreementTextInfo> AgreementTextInfos { get; set; }

        /// <summary>
        /// 产品是否已经签约。 已签约-SIGNED 未签约-UNSIGNED 未签约且未开通网商二类户-UNSIGNED_UNOPEN_ANTBANK_ACCOUNT
        /// </summary>
        [XmlElement("sign_result")]
        public string SignResult { get; set; }

        /// <summary>
        /// 子业务类型，标识该场景下的渠道模式。 SHBANK:上海银行模式 ANTBANK:网商银行模式
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
