using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCreditunionTppSubscribeResponse.
    /// </summary>
    public class ZhimaCreditEpCreditunionTppSubscribeResponse : AopResponse
    {
        /// <summary>
        /// 业务单号（唯一的业务单号，商户需要留存，用于关联订阅通知数据）
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 经营者信息（原样返回）
        /// </summary>
        [XmlElement("business_person")]
        public string BusinessPerson { get; set; }

        /// <summary>
        /// 企业名称（原样返回）
        /// </summary>
        [XmlElement("ent_name")]
        public string EntName { get; set; }

        /// <summary>
        /// 商户请求ID（原样返回）
        /// </summary>
        [XmlElement("merchant_request_id")]
        public string MerchantRequestId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 企业注册号（原样返回）
        /// </summary>
        [XmlElement("reg_no")]
        public string RegNo { get; set; }

        /// <summary>
        /// 入参类型（原样返回）
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 企业统一社会信用代码（原样返回）
        /// </summary>
        [XmlElement("uscc")]
        public string Uscc { get; set; }
    }
}
