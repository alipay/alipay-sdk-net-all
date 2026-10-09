using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerJobworthCloudresumeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerJobworthCloudresumeQueryModel : AopObject
    {
        /// <summary>
        /// 长效的认证令牌：zhima.credit.payafteruse.creditagreement.sign 的out_agreement_no
        /// </summary>
        [XmlElement("conn_key")]
        public string ConnKey { get; set; }

        /// <summary>
        /// 交换云简历的单次token：zhima.credit.payafteruse.creditagreement.sign 的  extra_param入参onceToken（授权后5分钟内，单次有效
        /// </summary>
        [XmlElement("once_token")]
        public string OnceToken { get; set; }
    }
}
