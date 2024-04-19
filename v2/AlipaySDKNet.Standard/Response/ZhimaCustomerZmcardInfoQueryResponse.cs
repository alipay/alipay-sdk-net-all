using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerZmcardInfoQueryResponse.
    /// </summary>
    public class ZhimaCustomerZmcardInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 被查看人的信用等级，范围[信用极好，信用优秀，信用良好，信用中等，信用较差]。用户已授权且接入方是二方商户才返回。
        /// </summary>
        [XmlElement("credit_level")]
        public string CreditLevel { get; set; }

        /// <summary>
        /// 用户的芝麻分分级编码。分值范围[A,B,C,D,E]，和credit_level对应。用户已授权且接入方是二方商户才返回。
        /// </summary>
        [XmlElement("level_code")]
        public string LevelCode { get; set; }

        /// <summary>
        /// 芝麻证页面拉端查看链接，主态：开通且已授权才会返回此url，客态：只要已开通就会返回此url。
        /// </summary>
        [XmlElement("skip_url")]
        public string SkipUrl { get; set; }

        /// <summary>
        /// 1.未开通芝麻返回ZM_ACCOUNT_NOT_EXISTED；2.未授权时会返回ZM_CARD_NO_AUTH；3.否则返回null。
        /// </summary>
        [XmlElement("sub_code")]
        public string SubCode { get; set; }
    }
}
