using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerEpCertificationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerEpCertificationQueryModel : AopObject
    {
        /// <summary>
        /// 一次认证的唯一标识，通过<a href="https://opendocs.alipay.com/apis/api_8/zhima.customer.ep.certification.initialize">zhima.customer.ep.certification.initialize</a>(企业认证初始化)接口完成芝麻认证初始化后获取。
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
