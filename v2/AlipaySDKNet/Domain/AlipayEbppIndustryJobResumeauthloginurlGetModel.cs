using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryJobResumeauthloginurlGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryJobResumeauthloginurlGetModel : AopObject
    {
        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 授权返回链接
        /// </summary>
        [XmlElement("return_complete_url")]
        public string ReturnCompleteUrl { get; set; }

        /// <summary>
        /// 模版ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
