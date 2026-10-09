using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalPaymentPreconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalPaymentPreconsultModel : AopObject
    {
        /// <summary>
        /// 支付金额,单位：元，精确到分。商保支付场景必选
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 当为商业保险支付是必须传入此参数
        /// </summary>
        [XmlElement("business_scene")]
        public string BusinessScene { get; set; }

        /// <summary>
        /// 商保支付场景必选
        /// </summary>
        [XmlElement("callback_url")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 商保支付场景必选
        /// </summary>
        [XmlElement("commercial_insurance_params")]
        public CommercialInsuranceParams CommercialInsuranceParams { get; set; }

        /// <summary>
        /// 药店标签，在异地就医场景中用于判断门店是否支持异地医保结算
        /// </summary>
        [XmlElement("drug_store_tag")]
        public string DrugStoreTag { get; set; }

        /// <summary>
        /// 定点医药机构所在地标准行政区划编码。可在<a href="http://xzqh.mca.gov.cn/map">民政部全国行政区划信息查询平台</a>查询
        /// </summary>
        [XmlElement("payment_city_code")]
        public string PaymentCityCode { get; set; }

        /// <summary>
        /// 用户证件号，目前只支持身份证号，用于判断是否与支付账户同一绑定用户
        /// </summary>
        [XmlElement("user_cert_no")]
        public string UserCertNo { get; set; }

        /// <summary>
        /// 当传入了证件号时，用来判断证件号类型，本期只支持身份证号
        /// </summary>
        [XmlElement("user_cert_type")]
        public string UserCertType { get; set; }

        /// <summary>
        /// 商保支付场景必选，其它场景可不填
        /// </summary>
        [XmlElement("user_mobile_no")]
        public string UserMobileNo { get; set; }

        /// <summary>
        /// 商保支付场景必选
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
