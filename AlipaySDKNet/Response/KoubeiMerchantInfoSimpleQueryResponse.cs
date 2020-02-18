using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMerchantInfoSimpleQueryResponse.
    /// </summary>
    public class KoubeiMerchantInfoSimpleQueryResponse : AopResponse
    {
        /// <summary>
        /// 操作员登录账号前缀，例如cc123@alitest.com#001
        /// </summary>
        [XmlElement("operator_prefix")]
        public string OperatorPrefix { get; set; }

        /// <summary>
        /// 商户id，2088121509924973
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
