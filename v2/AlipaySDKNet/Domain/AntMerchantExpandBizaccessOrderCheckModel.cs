using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandBizaccessOrderCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandBizaccessOrderCheckModel : AopObject
    {
        /// <summary>
        /// 受益人证照
        /// </summary>
        [XmlElement("benefit_info")]
        public CertificateInfoForEntry BenefitInfo { get; set; }

        /// <summary>
        /// 外部单号
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 服务商抽佣信息。本对象为空表示无需抽佣配置。一期只支持传入一个。
        /// </summary>
        [XmlArray("isv_commission_info")]
        [XmlArrayItem("isv_commission_info")]
        public List<IsvCommissionInfo> IsvCommissionInfo { get; set; }

        /// <summary>
        /// 法人证照
        /// </summary>
        [XmlElement("legal_info")]
        public CertificateInfoForEntry LegalInfo { get; set; }

        /// <summary>
        /// 法人登录号
        /// </summary>
        [XmlElement("legal_person_logon_id")]
        public string LegalPersonLogonId { get; set; }

        /// <summary>
        /// 商家主体证件信息。对于企业或个体户商户，其值为营业执照信息。事业单位、民办非当前无需传入。
        /// </summary>
        [XmlElement("license_info")]
        public CommonMerchantLicenseInfo LicenseInfo { get; set; }

        /// <summary>
        /// 商户二级类目code
        /// </summary>
        [XmlElement("mcc_code")]
        public string MccCode { get; set; }

        /// <summary>
        /// 商户登录号
        /// </summary>
        [XmlElement("merchant_logon_id")]
        public string MerchantLogonId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商户类型
        /// </summary>
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 是否需要代开发授权，默认为false。注意，如果重复发起代开发授权，会刷新商户的token。请调用后参考文档进行token重新获取。https://opendocs.alipay.com/isv/03l4iy?pathHash=92c490b7
        /// </summary>
        [XmlElement("need_interface_auth")]
        public bool NeedInterfaceAuth { get; set; }

        /// <summary>
        /// 是否需要代运营授权，默认为false
        /// </summary>
        [XmlElement("need_operation_auth")]
        public bool NeedOperationAuth { get; set; }

        /// <summary>
        /// 是否需要代入驻
        /// </summary>
        [XmlElement("need_register_merchant")]
        public bool NeedRegisterMerchant { get; set; }

        /// <summary>
        /// 某些场景，允许传入可选开通的产品。具体传参与业务BD联系沟通
        /// </summary>
        [XmlArray("optional_front_prod_code")]
        [XmlArrayItem("string")]
        public List<string> OptionalFrontProdCode { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 价格信息
        /// </summary>
        [XmlArray("price_infos")]
        [XmlArrayItem("merchant_price_related_info")]
        public List<MerchantPriceRelatedInfo> PriceInfos { get; set; }

        /// <summary>
        /// 商户上传资质详情
        /// </summary>
        [XmlArray("qualifications")]
        [XmlArrayItem("common_merchant_license_info")]
        public List<CommonMerchantLicenseInfo> Qualifications { get; set; }

        /// <summary>
        /// 服务商代商户业务开通的业务场景码，目前已开放AXF_MERCHANT_PERIOD_PAY安心付周期卡
        /// </summary>
        [XmlArray("scene_biz_code")]
        [XmlArrayItem("string")]
        public List<string> SceneBizCode { get; set; }
    }
}
