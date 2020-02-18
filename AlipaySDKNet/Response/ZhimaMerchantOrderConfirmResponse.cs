using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantOrderConfirmResponse.
    /// </summary>
    public class ZhimaMerchantOrderConfirmResponse : AopResponse
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 渠道来源
        /// </summary>
        [XmlElement("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 本次订单信用权益金额（如免押、极速付）
        /// </summary>
        [XmlElement("credit_amout")]
        public string CreditAmout { get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        [XmlElement("ethnic_group")]
        public string EthnicGroup { get; set; }

        /// <summary>
        /// 住宅地址，如：西湖区文三路168号
        /// </summary>
        [XmlElement("house")]
        public string House { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 蚂蚁开放平台商户不在使用此字段
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝userid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 人脸核身结果
        /// </summary>
        [XmlElement("zm_face")]
        public string ZmFace { get; set; }

        /// <summary>
        /// 较差、中等、良好、优秀、极好5个级别
        /// </summary>
        [XmlElement("zm_grade")]
        public string ZmGrade { get; set; }

        /// <summary>
        /// 芝麻风控产品集联合结果,Y/N
        /// </summary>
        [XmlElement("zm_risk")]
        public string ZmRisk { get; set; }

        /// <summary>
        /// 芝麻分
        /// </summary>
        [XmlElement("zm_score")]
        public string ZmScore { get; set; }
    }
}
