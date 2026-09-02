using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppPdeductSignQueryResponse.
    /// </summary>
    public class AlipayEbppPdeductSignQueryResponse : AopResponse
    {
        /// <summary>
        /// 协议ID
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 户号
        /// </summary>
        [XmlElement("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 出账机构
        /// </summary>
        [XmlElement("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 朗新协议ID
        /// </summary>
        [XmlElement("out_agreement_id")]
        public string OutAgreementId { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [XmlElement("sign_date")]
        public string SignDate { get; set; }

        /// <summary>
        /// 协议过期时间
        /// </summary>
        [XmlElement("sign_expire_date")]
        public string SignExpireDate { get; set; }

        /// <summary>
        /// 用户代扣协议设置的优先扣款渠道
        /// </summary>
        [XmlArray("specified_sort_channels")]
        [XmlArrayItem("specified_sort_channel_param")]
        public List<SpecifiedSortChannelParam> SpecifiedSortChannels { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
