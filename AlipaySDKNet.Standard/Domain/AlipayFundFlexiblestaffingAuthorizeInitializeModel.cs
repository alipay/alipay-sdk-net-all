using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundFlexiblestaffingAuthorizeInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundFlexiblestaffingAuthorizeInitializeModel : AopObject
    {
        /// <summary>
        /// 授权完成后的跳转地址，支持https的h5地址和小程序scheme url，不支持跳转支付宝端外app和页面。
        /// </summary>
        [XmlElement("back_url")]
        public string BackUrl { get; set; }

        /// <summary>
        /// 灵工授权场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 授权编码有效截止时间，可选，默认7天内有效，点时间超过截止时间后授权编码将会失效。格式：yyyy-MM-dd HH:mm:ss。注意：如果输入的格式不匹配，会报错参数异常，且过期时间最短不能小于一小时。
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 授权编码类型，有限枚举：1. SHORT_URL （短链接）2.PAGE_PARAM（小程序跳转参数）3.SHARE_CODE（小程序跳转参数）
        /// </summary>
        [XmlElement("initialize_code_type")]
        public string InitializeCodeType { get; set; }

        /// <summary>
        /// 外部业务号，调用方自定义提供，授权结果推送和授权结果查询中都会提供此单号，用于串联授权流程
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 授权主体信息
        /// </summary>
        [XmlElement("principal_party_info")]
        public PrincipalPartyInfo PrincipalPartyInfo { get; set; }

        /// <summary>
        /// 灵工授权产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
