using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerJobworthAuthenticationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerJobworthAuthenticationQueryModel : AopObject
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// "身份证 : 0"，"护照: 1"，"台湾往来通行证：4","港澳往来通行证：3", "回乡证: 2"；"港澳证件：5"
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 调用第一步创建接口的out_agreement_no，由外部传入
        /// </summary>
        [XmlElement("conn_key")]
        public string ConnKey { get; set; }

        /// <summary>
        /// 01:医生，02:教师，具体参考文档
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 查询身份认证结果的凭证，在认证结果到达终态后只允许查询成功一次，若需要再次查询，则需要调用第一个接口再拉起受理台
        /// </summary>
        [XmlElement("once_token")]
        public string OnceToken { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID 和身份证任选一个传入
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// exact:精确查询,dim:模糊查询
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// 信用服务id，商家接入产品功能包时有运营同学分配
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID 和身份证任选一个传入
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
