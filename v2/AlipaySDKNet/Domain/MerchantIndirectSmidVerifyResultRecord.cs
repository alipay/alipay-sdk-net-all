using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantIndirectSmidVerifyResultRecord Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantIndirectSmidVerifyResultRecord : AopObject
    {
        /// <summary>
        /// org_id
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 商户smid (支付宝进件商户号)
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 校验结果值
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 如果校验失败，返回用户的提示信息(如果校验失败，此参数为必填)
        /// </summary>
        [XmlElement("verifiy_failed_msg")]
        public string VerifiyFailedMsg { get; set; }

        /// <summary>
        /// 校验结果(true=允许用户访问小程序，false=禁止用户访问小程序)
        /// </summary>
        [XmlElement("verifiy_result")]
        public bool VerifiyResult { get; set; }
    }
}
