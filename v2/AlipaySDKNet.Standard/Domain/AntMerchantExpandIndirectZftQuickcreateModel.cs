using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectZftQuickcreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectZftQuickcreateModel : AopObject
    {
        /// <summary>
        /// 补充证件图片，与additional_cert_no、additional_cert_type同时提供。当商户类型为个人时，使用当面付收款有限额，补充这组证件信息可提额。目前仅允许个人类型商户传入。其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。
        /// </summary>
        [XmlElement("additional_cert_image")]
        public string AdditionalCertImage { get; set; }

        /// <summary>
        /// 补充证件号，与additional_cert_type+additional_cert_image同时提供。当商户类型为个人时，使用当面付收款有限额，补充这组证件信息可提额。目前仅允许个人类型商户传入本字段。
        /// </summary>
        [XmlElement("additional_cert_no")]
        public string AdditionalCertNo { get; set; }

        /// <summary>
        /// 补充证件类型，与additional_cert_no+additional_cert_image同时提供。可选值有201（营业执照号）、204（民办非企业登记证书）、206（社会团体法人登记证书）、218（事业单位法人证书）、219（党政机关批准设立文件/行政执法主体资格证）。当商户类型为个人时，使用当面付收款有限额，补充这组证件信息可提额。目前仅允许个人类型商户传入本字段。
        /// </summary>
        [XmlElement("additional_cert_type")]
        public string AdditionalCertType { get; set; }

        /// <summary>
        /// 商户别名。支付宝账单中的商户名称会展示此处设置的别名，如果涉及支付宝APP内的支付，支付结果页也会展示该别名。如果涉及当面付场景，请填写线下店铺名称
        /// </summary>
        [XmlElement("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 结算支付宝账号，结算账号使用支付宝账号时必填。本字段要求与商户名称name同名，且是实名认证支付宝账户(个体工商户可以与name或cert_name相同)
        /// </summary>
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 签约支付宝账户。需使用实名认证支付宝账号，使用该支付宝账号签约二级商户及后续服务，商户主体与该支付宝账号主体相同
        /// </summary>
        [XmlElement("binding_alipay_logon_id")]
        public string BindingAlipayLogonId { get; set; }

        /// <summary>
        /// 结算银行卡，如果结算到支付宝账号，则不需要填写。本业务当前只允许传入一张结算卡。个人类型商户不允许结算到银行卡
        /// </summary>
        [XmlArray("biz_cards")]
        [XmlArrayItem("settle_card_info")]
        public List<SettleCardInfo> BizCards { get; set; }

        /// <summary>
        /// 经营地址。当使用当面付服务时，本字段要求必填。地址对象中省、市、区、地址必填，其余选填
        /// </summary>
        [XmlElement("business_address")]
        public AddressInfo BusinessAddress { get; set; }

        /// <summary>
        /// 商户联系人信息。在本业务中，ContactInfo对象中联系人姓名，手机号必填，其他选填
        /// </summary>
        [XmlArray("contact_infos")]
        [XmlArrayItem("contact_info")]
        public List<ContactInfo> ContactInfos { get; set; }

        /// <summary>
        /// 默认结算规则。当调用收单接口，结算条款中设置默认结算规则时，交易资金将结算至此处设置的默认结算目标账户中。其详细描述及收单接口传参示例参考功能包文档
        /// </summary>
        [XmlElement("default_settle_rule")]
        public DefaultSettleRule DefaultSettleRule { get; set; }

        /// <summary>
        /// 商户编号，由机构定义，需要保证在机构下唯一
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 内景照，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。如果使用当面付服务则必填
        /// </summary>
        [XmlArray("in_door_images")]
        [XmlArrayItem("string")]
        public List<string> InDoorImages { get; set; }

        /// <summary>
        /// （平替原来的info_source_uid字段，如果能拿到openId，请传本字段，原字段留空）。信息关联的openId
        /// </summary>
        [XmlElement("info_source_open_id")]
        public string InfoSourceOpenId { get; set; }

        /// <summary>
        /// （已废弃，请使用info_source_open_id）。信息关联的uid
        /// </summary>
        [XmlElement("info_source_uid")]
        public string InfoSourceUid { get; set; }

        /// <summary>
        /// 开票资料信息
        /// </summary>
        [XmlElement("invoice_info")]
        public MerchantInvoiceInfo InvoiceInfo { get; set; }

        /// <summary>
        /// 授权函。当商户名与结算卡户名不一致。<a href="https://opendocs.alipay.com/open/direct-payment/cg5mkp#%E7%9B%B8%E5%85%B3%E8%B5%84%E6%96%99">《说明函》模板参考</a>。涉及外籍法人（这种情况上传任意能证明身份的图片）时必填，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。（<b>商户类型为个体工商户时，本字段仅需上传营业执照非授权函</b>）
        /// </summary>
        [XmlElement("license_auth_letter_image")]
        public string LicenseAuthLetterImage { get; set; }

        /// <summary>
        /// 商户类别码 mcc，可查看  <a href="https://mdn.alipayobjects.com/huamei_fctrxv/afts/file/A*3TMHRZ8ppa4AAAAAAAAAAAAADs2DAQ/%E8%BF%9B%E4%BB%B6MCC%E4%B8%8E%E8%B5%84%E8%B4%A8%E8%A6%81%E6%B1%82202212.xlsx">进件MCC与资质要求 202212.xlsx</a>，特殊行业要按照MCC说明中的资质一栏上传辅助资质，辅助资质要在 qualifications 中上传，会有人工审核。
        /// </summary>
        [XmlElement("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// 进件的二级商户名称。一般情况下要与证件的名称相同。个体工商户类型可以放宽到法人名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 门头照，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。如果使用当面付服务则必填
        /// </summary>
        [XmlArray("out_door_images")]
        [XmlArrayItem("string")]
        public List<string> OutDoorImages { get; set; }

        /// <summary>
        /// （已废弃，请使用oversea_settle_open_id）境外结算账号
        /// </summary>
        [XmlElement("oversea_settle_account")]
        public string OverseaSettleAccount { get; set; }

        /// <summary>
        /// （平替原来的oversea_settle_open_id字段，如能够获取到该场景的open_id，请传本字段，原字段留空）境外结算账号
        /// </summary>
        [XmlElement("oversea_settle_open_id")]
        public string OverseaSettleOpenId { get; set; }

        /// <summary>
        /// 商户行业资质，当商户是特殊行业时必填。每项行业资质信息中，industry_qualification_type和industry_qualification_image均必填
        /// </summary>
        [XmlArray("qualifications")]
        [XmlArrayItem("industry_qualification_info")]
        public List<IndustryQualificationInfo> Qualifications { get; set; }

        /// <summary>
        /// 商户使用服务，可选值有：当面付、jsapi支付、app支付、wap支付、电脑支付、线上资金预授权、新当面资金授权、预授权支付、商户代扣、小程序支付。其值会影响其他字段必填性，详见其他字段描述
        /// </summary>
        [XmlArray("service")]
        [XmlArrayItem("string")]
        public List<string> Service { get; set; }

        /// <summary>
        /// 客服电话
        /// </summary>
        [XmlElement("service_phone")]
        public string ServicePhone { get; set; }

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
    }
}
