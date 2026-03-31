using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpInteopBrandchainCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpInteopBrandchainCreateModel : AopObject
    {
        /// <summary>
        /// 银行卡信息
        /// </summary>
        [XmlElement("bank_card_info")]
        public BrandChainBankCardInfo BankCardInfo { get; set; }

        /// <summary>
        /// 品牌小程序appId
        /// </summary>
        [XmlElement("brand_app_id")]
        public string BrandAppId { get; set; }

        /// <summary>
        /// 【重要提示】申请特殊费率时，请务必提供营业执照以提升审核通过率。
        /// </summary>
        [XmlElement("business_license_info")]
        public BusinessLicenseInfo BusinessLicenseInfo { get; set; }

        /// <summary>
        /// 商家联系方式
        /// </summary>
        [XmlElement("contact_info")]
        public BrandChainContactInfo ContactInfo { get; set; }

        /// <summary>
        /// 当面付产品费率，单位：只可以小数不能填百分号，最多小数点后两位，范围为0.38～1.0。
        /// </summary>
        [XmlElement("face_to_face_rate")]
        public string FaceToFaceRate { get; set; }

        /// <summary>
        /// 一体化作业开通主单号，单号为服务商一体化作业主单创建返回值。
        /// </summary>
        [XmlElement("inteop_order_no")]
        public string InteopOrderNo { get; set; }

        /// <summary>
        /// jsapi支付产品费率值，单位：只可以小数不能填百分号，最多小数点后两位，范围为0.38～1.0。
        /// </summary>
        [XmlElement("jsapi_pay_rate")]
        public string JsapiPayRate { get; set; }

        /// <summary>
        /// 商家经营类目编码。参见 <a href="https://opendocs.alipay.com/common/02khjv">商家经营类目2.0</a> 中的“一级类目code_二级类目code”。
        /// </summary>
        [XmlElement("mcc_code")]
        public string MccCode { get; set; }

        /// <summary>
        /// 店铺信息
        /// </summary>
        [XmlElement("shop_info")]
        public BrandChainShopInfo ShopInfo { get; set; }

        /// <summary>
        /// 特殊行业资质信息
        /// </summary>
        [XmlElement("special_license_info")]
        public SpecialLicenseInfo SpecialLicenseInfo { get; set; }
    }
}
