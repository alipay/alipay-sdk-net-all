using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsresourceapiBizuserDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsresourceapiBizuserDeleteModel : AopObject
    {
        /// <summary>
        /// 业务方用户id
        /// </summary>
        [XmlElement("biz_user_id")]
        public string BizUserId { get; set; }

        /// <summary>
        /// 清退类型：主动离职（可重新入职），质量清退（同步拉黑）不可再入职
        /// </summary>
        [XmlElement("leave_type")]
        public string LeaveType { get; set; }

        /// <summary>
        /// 删除原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 租户名称
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
