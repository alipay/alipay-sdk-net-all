using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSolutionprodUnifiedopenApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSolutionprodUnifiedopenApplyModel : AopObject
    {
        /// <summary>
        /// 结果页点击完成后的跳转地址 1、跳转类型为ALIPAY_URL，back_url就做支付宝端内跳转 2、跳转类型为MERCHANT_URL，back_url就跳转到端外
        /// </summary>
        [XmlElement("back_url")]
        public string BackUrl { get; set; }

        /// <summary>
        /// 用于开通完成之后的回跳地址类型： 1、类型为MERCHANT_URL，代表需要回跳至端外商户地址，back_url按照跳端方式拼接 2、类型为ALIPAY_URL，代表需要回跳至支付宝端内地址，back_url按照跳支付宝端内方式拼接，支持小程序或h5
        /// </summary>
        [XmlElement("back_url_type")]
        public string BackUrlType { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型。 目前只支持传入100（大陆身份证）
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 开通项详情
        /// </summary>
        [XmlArray("open_item_list")]
        [XmlArrayItem("uni_open_req_item")]
        public List<UniOpenReqItem> OpenItemList { get; set; }

        /// <summary>
        /// 外部单据号，由商家自定义。64个字符以内，仅可包含字母、数字、下划线。需保证在商户端不重复。该参数用于幂等
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 个人收款方真实姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 解决方案code
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }

        /// <summary>
        /// 指定开通用户支付宝登录号 需要指定开通用户时，与target_user_id、target_user_open_id三选一
        /// </summary>
        [XmlElement("target_logon_id")]
        public string TargetLogonId { get; set; }

        /// <summary>
        /// 指定开通用户支付宝唯一用户号 需要指定开通用户时，与target_logon_id、target_user_open_id三选一
        /// </summary>
        [XmlElement("target_user_id")]
        public string TargetUserId { get; set; }

        /// <summary>
        /// 指定开通用户支付宝openId。为了标记支付宝用户在应用下的唯一标识 需要指定开通用户时，与target_user_id、target_logon_id三选一
        /// </summary>
        [XmlElement("target_user_open_id")]
        public string TargetUserOpenId { get; set; }
    }
}
