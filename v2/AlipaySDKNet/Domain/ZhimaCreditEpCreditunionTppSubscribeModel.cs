using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpCreditunionTppSubscribeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpCreditunionTppSubscribeModel : AopObject
    {
        /// <summary>
        /// 授权单号
        /// </summary>
        [XmlElement("auth_id")]
        public string AuthId { get; set; }

        /// <summary>
        /// 经营者信息（经营者证件号（ sha256 加密））
        /// </summary>
        [XmlElement("business_person")]
        public string BusinessPerson { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("ent_name")]
        public string EntName { get; set; }

        /// <summary>
        /// 商户请求ID（需要唯一，有幂等校验）
        /// </summary>
        [XmlElement("merchant_request_id")]
        public string MerchantRequestId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 企业注册号
        /// </summary>
        [XmlElement("reg_no")]
        public string RegNo { get; set; }

        /// <summary>
        /// 入参类型（企业入参：企业KEY三选一必填，建议统代>注册号>企业名称；经营者入参：经营者信息必填）
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 企业统一社会信用代码
        /// </summary>
        [XmlElement("uscc")]
        public string Uscc { get; set; }
    }
}
