using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectZftforcCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectZftforcCreateModel : AopObject
    {
        /// <summary>
        /// 支付宝收银台及账单中的商户名称会展示此处设置的别名。如果涉及支付宝APP内的支付，支付结果页也会展示该别名；如果涉及线下当面付场景，请填写线下店铺名称
        /// </summary>
        [XmlElement("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 结算账号使用支付宝账号时必填，本字段指定交易资金结算的具体支付宝账号，与binding_alipay_logon_id保持一致
        /// </summary>
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 需使用实名认证支付宝账号，使用该支付宝账号签约直付通二级商户及后续服务，商户主体与该支付宝账号主体相同
        /// </summary>
        [XmlElement("binding_alipay_logon_id")]
        public string BindingAlipayLogonId { get; set; }

        /// <summary>
        /// 证件号。若传入签约支付宝账号，该字段无效
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型。若传入签约支付宝账号，该字段无效
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 在本业务中，ContactInfo对象中联系人姓名，手机号必填，其他选填
        /// </summary>
        [XmlArray("contact_infos")]
        [XmlArrayItem("contact_info")]
        public List<ContactInfo> ContactInfos { get; set; }

        /// <summary>
        /// 由机构定义,需要保证在机构下唯一
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 平台商回跳地址
        /// </summary>
        [XmlElement("jump_back_url")]
        public string JumpBackUrl { get; set; }

        /// <summary>
        /// 商户类别码 mcc（和行业约定），可查看  <a href="https://mdn.alipayobjects.com/huamei_fctrxv/afts/file/A*3TMHRZ8ppa4AAAAAAAAAAAAADs2DAQ/%E8%BF%9B%E4%BB%B6MCC%E4%B8%8E%E8%B5%84%E8%B4%A8%E8%A6%81%E6%B1%82202212.xlsx">进件MCC与资质要求 202212.xlsx</a>，不支持特殊mcc
        /// </summary>
        [XmlElement("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// 用户名称。若传入签约支付宝账号，该字段无效
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商户使用服务, 固定传（jsapi支付、app支付、wap支付、电脑支付、小程序支付）
        /// </summary>
        [XmlArray("service")]
        [XmlArrayItem("string")]
        public List<string> Service { get; set; }

        /// <summary>
        /// 二级商户与服务商的签约时间
        /// </summary>
        [XmlElement("sign_time_with_isv")]
        public string SignTimeWithIsv { get; set; }

        /// <summary>
        /// 商户站点信息，包括网站、app、小程序。商户使用服务包含电脑支付、wap支付时，必须填充一个类型为01(网站)的SiteInfo对象，site_type/site_url/site_name必填；当包含app支付时，必须至少填充类型为02(APP)或06(支付宝小程序)中一种类型的SiteInfo对象，site_type/site_name必填；当包含jsapi支付时，必须填充一个类型为06(支付宝小程序)的SiteInfo对象；
        /// </summary>
        [XmlArray("sites")]
        [XmlArrayItem("site_info")]
        public List<SiteInfo> Sites { get; set; }

        /// <summary>
        /// 根据平台商签约开户维度
        /// </summary>
        [XmlElement("sub_scene")]
        public string SubScene { get; set; }
    }
}
