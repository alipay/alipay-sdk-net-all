using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectZftsubsettleQueryResponse.
    /// </summary>
    public class AntMerchantExpandIndirectZftsubsettleQueryResponse : AopResponse
    {
        /// <summary>
        /// 二级商户结算账号
        /// </summary>
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 映射字段
        /// </summary>
        [XmlElement("alipay_logon_open_id")]
        public string AlipayLogonOpenId { get; set; }

        /// <summary>
        /// 二级商户结算账号的2088id
        /// </summary>
        [XmlElement("alipay_logon_uid")]
        public string AlipayLogonUid { get; set; }

        /// <summary>
        /// 结算银行卡
        /// </summary>
        [XmlArray("biz_cards")]
        [XmlArrayItem("settle_card_info")]
        public List<SettleCardInfo> BizCards { get; set; }

        /// <summary>
        /// 默认结算规则
        /// </summary>
        [XmlElement("default_settle_rule")]
        public DefaultSettleRule DefaultSettleRule { get; set; }
    }
}
