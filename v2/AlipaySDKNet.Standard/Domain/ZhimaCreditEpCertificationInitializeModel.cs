using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpCertificationInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpCertificationInitializeModel : AopObject
    {
        /// <summary>
        /// 支付宝登陆账号(邮箱或者手机号)
        /// </summary>
        [XmlElement("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 认证类别，由蚂蚁企业信用方分发提供，配置有误会返回参数错误
        /// </summary>
        [XmlElement("certify_category")]
        public string CertifyCategory { get; set; }

        /// <summary>
        /// 使用蚂蚁企业信用认证服务后，回跳到该商户指定的地址
        /// </summary>
        [XmlElement("certify_return_url")]
        public string CertifyReturnUrl { get; set; }

        /// <summary>
        /// 仅针对有委托书需求的平台商户，后台沟通确定委托书模版后（包括参数key和值格式以及是否必填等业务校验），可通过该字段传入平台业务参数用于委托书渲染。
        /// </summary>
        [XmlElement("customize_content")]
        public string CustomizeContent { get; set; }

        /// <summary>
        /// 统一社会信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业全称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户唯一业务流水号，由大小写字母和数字构成
        /// </summary>
        [XmlElement("org_biz_no")]
        public string OrgBizNo { get; set; }

        /// <summary>
        /// 产品码，请填写示例值里提供的值
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 证件号码，仅支持身份证号
        /// </summary>
        [XmlElement("user_cert_no")]
        public string UserCertNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 个人用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }
    }
}
