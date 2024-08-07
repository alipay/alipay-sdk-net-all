using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateMultideductTokenApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateMultideductTokenApplyModel : AopObject
    {
        /// <summary>
        /// 业务码。可选的字段枚举说明：{SCHOOL_MULTI_DEDUCT:校园支付;SCHOOL_PAYMENT:刷脸支付}
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// operationType 操作类型。可选的字段枚举说明：{SIGN_SCHOOL_DEDUCT:签约校园支付;QUERY_DETAIL:查询校园支付;OPEN_SMALL_POUCH:家长开通小荷包}
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 家长手机号。SIGN_SCHOOL_DEDUCT时提供会在签约时自动筛选并推荐家长支付宝账号
        /// </summary>
        [XmlElement("parent_phone")]
        public string ParentPhone { get; set; }

        /// <summary>
        /// 支付设置。SIGN_SCHOOL_DEDUCT或OPEN_SMALL_POUCH时必传
        /// </summary>
        [XmlElement("pay_config")]
        public PayConfig PayConfig { get; set; }

        /// <summary>
        /// 学校（或教育机构）内标。支付宝提供的学校编号，如果您不知道学校编号，可以联系您的BD咨询获取
        /// </summary>
        [XmlElement("school_code")]
        public string SchoolCode { get; set; }

        /// <summary>
        /// 学生或教职工的证件号。OPEN_SMALL_POUCH时可选，其他情况必填
        /// </summary>
        [XmlElement("user_cert_no")]
        public string UserCertNo { get; set; }

        /// <summary>
        /// 学生或教职工的证件类型。可选的字段枚举说明：{1:居民身份证; RP_HK_MC:港澳居民居住证; RP_TAIWAN:台湾居民居住证}。OPEN_SMALL_POUCH时可选，其他情况必填
        /// </summary>
        [XmlElement("user_cert_type")]
        public string UserCertType { get; set; }

        /// <summary>
        /// 学生或教职工的姓名。OPEN_SMALL_POUCH时可选，其他情况必填
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 学生或教职工在学校（或教育机构）的唯一编号（由商户自己生成）。支付宝侧后续通知不会告知学生证件信息，只返回当前唯一标号，商户需要据此识别出校内学生（结合学校（或教育机构）外标）。OPEN_SMALL_POUCH时可选，其他情况必填
        /// </summary>
        [XmlElement("user_unique_id")]
        public string UserUniqueId { get; set; }
    }
}
