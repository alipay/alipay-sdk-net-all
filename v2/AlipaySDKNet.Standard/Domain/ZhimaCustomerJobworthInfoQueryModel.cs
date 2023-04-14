using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerJobworthInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerJobworthInfoQueryModel : AopObject
    {
        /// <summary>
        /// 若用户没有开通工作证或者芝麻，成功开通后回跳的链接 ，支持http或schema地址
        /// </summary>
        [XmlElement("back_url")]
        public string BackUrl { get; set; }

        /// <summary>
        /// 证件号 ，根据cert_type类型设置对应证件号码，选择身份证校验时必传
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型 ，枚举值： 0:身份证1:护照2:台湾同胞回乡证3:港澳居民往来内地通行证4:台湾居民通行证5:港澳居民通行证 选择身份证校验时必传，支付宝uid或身份证+身份证类型 查询2选1，都设置时uid优先
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 子场景
        /// </summary>
        [XmlElement("cloud_resume_scene")]
        public string CloudResumeScene { get; set; }

        /// <summary>
        /// 公司社会统一代码h5页面访客展示使用
        /// </summary>
        [XmlElement("company_certificate")]
        public string CompanyCertificate { get; set; }

        /// <summary>
        /// 外部订单号，zhima.credit.payafteruse.creditagreement.sign的入参 out_agreement_no智能简历场景支持只传该值
        /// </summary>
        [XmlElement("conn_key")]
        public string ConnKey { get; set; }

        /// <summary>
        /// 在h5页面是否展示底部跳转按钮
        /// </summary>
        [XmlElement("has_button")]
        public bool HasButton { get; set; }

        /// <summary>
        /// 是否需要返回h5页面
        /// </summary>
        [XmlElement("has_html")]
        public bool HasHtml { get; set; }

        /// <summary>
        /// true or false 是否展示
        /// </summary>
        [XmlElement("has_number")]
        public bool HasNumber { get; set; }

        /// <summary>
        /// 是否展示二维码
        /// </summary>
        [XmlElement("has_qr_code")]
        public bool HasQrCode { get; set; }

        /// <summary>
        /// 行业描述ID
        /// </summary>
        [XmlElement("industry_id")]
        public string IndustryId { get; set; }

        /// <summary>
        /// 对外使用的jobid
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 商户内部的唯一id如果是需要返回h5页面必填
        /// </summary>
        [XmlElement("ka_visitor_id")]
        public string KaVisitorId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID ，为2088开头的唯一标识 选择支付宝uid检验时必传，支付宝uid或身份证+身份证类型 查询2选1，都设置时uid优先
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID ，为2088开头的唯一标识 选择支付宝uid检验时必传，支付宝uid或身份证+身份证类型 查询2选1，都设置时uid优先
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 商户侧配置访客名称 如果是需要返回h5页面必填
        /// </summary>
        [XmlElement("visitor_name")]
        public string VisitorName { get; set; }

        /// <summary>
        /// 访问类型 C = company  or P = person 如果是需要返回h5页面必填
        /// </summary>
        [XmlElement("visitor_type")]
        public string VisitorType { get; set; }

        /// <summary>
        /// 上传图片接口返回的id
        /// </summary>
        [XmlElement("visitor_url")]
        public string VisitorUrl { get; set; }
    }
}
