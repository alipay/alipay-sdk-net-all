using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBusinessRelationAlipayaccountQueryResponse.
    /// </summary>
    public class AlipayBusinessRelationAlipayaccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 商业关系收单pid支付宝账号
        /// </summary>
        [XmlElement("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 商业关系收单pid支付宝实名名称
        /// </summary>
        [XmlElement("alipay_name")]
        public string AlipayName { get; set; }
    }
}
