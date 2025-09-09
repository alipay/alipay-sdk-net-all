using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StaffInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class StaffInfoVO : AopObject
    {
        /// <summary>
        /// 支付宝账号
        /// </summary>
        [XmlElement("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("community_ids")]
        [XmlArrayItem("string")]
        public List<string> CommunityIds { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("department_jobs")]
        [XmlArrayItem("department_job_create_v_o")]
        public List<DepartmentJobCreateVO> DepartmentJobs { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 支付宝openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 是否开通平台操作员 开通：true 不开通：false 默认
        /// </summary>
        [XmlElement("open_saas")]
        public bool OpenSaas { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 员工id,新增时非必填，更新是必填 
        /// </summary>
        [XmlElement("staff_id")]
        public string StaffId { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        [XmlElement("staff_no")]
        public string StaffNo { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
