using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentFastAuditInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentFastAuditInfoVO : AopObject
    {
        /// <summary>
        /// 极速审核任务信息
        /// </summary>
        [XmlArray("fast_audit_task_info_list")]
        [XmlArrayItem("rent_fast_audit_task_info_v_o")]
        public List<RentFastAuditTaskInfoVO> FastAuditTaskInfoList { get; set; }

        /// <summary>
        /// 极速审核页面连接地址
        /// </summary>
        [XmlElement("fast_audit_url")]
        public string FastAuditUrl { get; set; }

        /// <summary>
        /// 审核资料安全密钥，用于对content进行解密
        /// </summary>
        [XmlElement("secure_key")]
        public string SecureKey { get; set; }
    }
}
