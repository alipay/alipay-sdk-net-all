using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertificateUseRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CertificateUseRuleInfo : AopObject
    {
        /// <summary>
        /// 对应本地生活商品模版属性中的时间限制(use_limit)，参考本地生活商品模板文档：https://opendocs.alipay.com/pre-open/07pywg?pathHash=1c499cb5
        /// </summary>
        [XmlElement("use_limit")]
        public string UseLimit { get; set; }

        /// <summary>
        /// 对应本地生活商品模版属性中的使用张数限制(use_num_limit)，参考本地生活商品模板文档：https://opendocs.alipay.com/pre-open/07pywg?pathHash=1c499cb5
        /// </summary>
        [XmlElement("use_num_limit")]
        public string UseNumLimit { get; set; }
    }
}
