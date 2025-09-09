using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdReportmetricQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdReportmetricQueryModel : AopObject
    {
        /// <summary>
        /// 代理商商家标识,在广告投放平台代理商详情获取。<a href="https://opendocs.alipay.com/xlight/0eucvz?pathHash=dc01fadb">获取文档</a>
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }
    }
}
