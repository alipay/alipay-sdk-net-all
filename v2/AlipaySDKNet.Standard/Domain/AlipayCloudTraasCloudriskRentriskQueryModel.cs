using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudTraasCloudriskRentriskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudTraasCloudriskRentriskQueryModel : AopObject
    {
        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 商家自定义需保证在商户端不重复
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 用户授权
        /// </summary>
        [XmlElement("user_authorization")]
        public string UserAuthorization { get; set; }
    }
}
