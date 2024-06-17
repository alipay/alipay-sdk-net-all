using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalNationalPayAuthInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalNationalPayAuthInfo : AopObject
    {
        /// <summary>
        /// 线上支付授权流水号
        /// </summary>
        [XmlElement("auth_no")]
        public string AuthNo { get; set; }

        /// <summary>
        /// 用户授权状态
        /// </summary>
        [XmlElement("auth_stas")]
        public string AuthStas { get; set; }

        /// <summary>
        /// 授权时间
        /// </summary>
        [XmlElement("auth_time")]
        public string AuthTime { get; set; }

        /// <summary>
        /// 线上授权确认页链接
        /// </summary>
        [XmlElement("auth_url")]
        public string AuthUrl { get; set; }

        /// <summary>
        /// 电子凭证中心线上身份核验返回的默认参保地
        /// </summary>
        [XmlElement("insu_org")]
        public string InsuOrg { get; set; }

        /// <summary>
        /// 就诊用户卡信息中机构内卡号,授权成功时返回
        /// </summary>
        [XmlElement("medical_card_id")]
        public string MedicalCardId { get; set; }

        /// <summary>
        /// 就诊用户卡信息中机构编码,授权成功时返回
        /// </summary>
        [XmlElement("medical_card_inst_id")]
        public string MedicalCardInstId { get; set; }

        /// <summary>
        /// 本人凭证激活状态
        /// </summary>
        [XmlElement("medical_card_status")]
        public string MedicalCardStatus { get; set; }

        /// <summary>
        /// 开放平台应用Id
        /// </summary>
        [XmlElement("openapi_app_id")]
        public string OpenapiAppId { get; set; }

        /// <summary>
        /// 线上支付授权编码,authStas=1且线上业务类型编码等于04107才返回该值
        /// </summary>
        [XmlElement("pay_auth_no")]
        public string PayAuthNo { get; set; }

        /// <summary>
        /// 亲情账户绑定状态，在rels_pay_flag=1时返回
        /// </summary>
        [XmlElement("rels_medical_card_status")]
        public string RelsMedicalCardStatus { get; set; }

        /// <summary>
        /// 授权类型 本人授权-0 亲情账户授权-1
        /// </summary>
        [XmlElement("rels_pay_flag")]
        public string RelsPayFlag { get; set; }

        /// <summary>
        /// 如果授权人类型为亲情账户授权，该字段必填，返回主账户脱敏姓名
        /// </summary>
        [XmlElement("rels_pay_user_name")]
        public string RelsPayUserName { get; set; }

        /// <summary>
        /// 商户请求流水号
        /// </summary>
        [XmlElement("req_biz_no")]
        public string ReqBizNo { get; set; }
    }
}
