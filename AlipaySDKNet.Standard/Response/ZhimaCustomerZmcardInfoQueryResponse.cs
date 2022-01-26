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
        /// 被查看人的信用等级
        /// </summary>
        [XmlElement("credit_level")]
        public string CreditLevel { get; set; }

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
