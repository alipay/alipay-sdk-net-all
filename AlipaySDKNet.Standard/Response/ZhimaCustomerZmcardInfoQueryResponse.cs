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
        /// 被查看人的信用等级，范围[信用极好，信用优秀，信用良好，信用中等，信用较差]
        /// </summary>
        [XmlElement("credit_level")]
        public string CreditLevel { get; set; }

        /// <summary>
        /// 用户的芝麻分分级编码。分值范围[A,B,C,D,E]
        /// </summary>
        [XmlElement("level_code")]
        public string LevelCode { get; set; }

        /// <summary>
        /// 芝麻证h5跳转链接，若被查看人已经授权，则会返回此url，点击后进入芝麻证h5页面
        /// </summary>
        [XmlElement("skip_url")]
        public string SkipUrl { get; set; }

        /// <summary>
        /// 需要升级授权，此情况也调用服务开通api zhima.credit.payafteruse.creditagreement.sign
        /// </summary>
        [XmlElement("sub_code")]
        public string SubCode { get; set; }
    }
}
