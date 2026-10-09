using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAuthUserauthRelationQueryResponse.
    /// </summary>
    public class AlipayOpenAuthUserauthRelationQueryResponse : AopResponse
    {
        /// <summary>
        /// 应用logo地址
        /// </summary>
        [XmlElement("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 授权协议列表，例如：[{"download_link":null,"agreement_name":"校园信息服务须知","link":"https://render.alipay.com/p/c/17gitw20onek"},{"download_link":"https://render.alipay.com/p/yuyan/180020010001196791/preview.html?agreementId=AG00000049","agreement_name":"用户授权协议","link":"https://render.alipay.com/p/yuyan/180020010001196791/preview.html?agreementId=AG00000049"}]
        /// </summary>
        [XmlArray("auth_agreements")]
        [XmlArrayItem("user_auth_agreement")]
        public List<UserAuthAgreement> AuthAgreements { get; set; }

        /// <summary>
        /// 授权文案，列表类型，一个元素为一行
        /// </summary>
        [XmlArray("auth_content")]
        [XmlArrayItem("string")]
        public List<string> AuthContent { get; set; }

        /// <summary>
        /// 授权截止有效期，为空表示长期有效
        /// </summary>
        [XmlElement("auth_end")]
        public string AuthEnd { get; set; }

        /// <summary>
        /// 授权开始时间
        /// </summary>
        [XmlElement("auth_start")]
        public string AuthStart { get; set; }
    }
}
