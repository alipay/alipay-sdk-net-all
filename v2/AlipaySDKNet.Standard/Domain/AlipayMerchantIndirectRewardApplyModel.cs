using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIndirectRewardApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIndirectRewardApplyModel : AopObject
    {
        /// <summary>
        /// 业务场景编码，用以区分不同的业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 商户账号组ID
        /// </summary>
        [XmlElement("group_mid")]
        public string GroupMid { get; set; }

        /// <summary>
        /// 支付宝登录号
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 营销任务编码，平台定义的任务类型编号
        /// </summary>
        [XmlElement("task_code")]
        public string TaskCode { get; set; }

        /// <summary>
        /// 营销任务唯一编号，报名任务时返回
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
