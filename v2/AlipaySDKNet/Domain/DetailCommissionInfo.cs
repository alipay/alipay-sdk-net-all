using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DetailCommissionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DetailCommissionInfo : AopObject
    {
        /// <summary>
        /// 配置失效时间
        /// </summary>
        [XmlElement("alloc_invalid_time")]
        public string AllocInvalidTime { get; set; }

        /// <summary>
        /// 配置生效时间
        /// </summary>
        [XmlElement("alloc_valid_time")]
        public string AllocValidTime { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("commission_role_list")]
        [XmlArrayItem("detail_commission_role_info")]
        public List<DetailCommissionRoleInfo> CommissionRoleList { get; set; }

        /// <summary>
        /// 抽佣状态
        /// </summary>
        [XmlElement("commission_status")]
        public string CommissionStatus { get; set; }

        /// <summary>
        /// 抽佣比例
        /// </summary>
        [XmlElement("isv_rate")]
        public string IsvRate { get; set; }

        /// <summary>
        /// 最新抽佣信息
        /// </summary>
        [XmlElement("latest_commission")]
        public LatestCommissionInfo LatestCommission { get; set; }

        /// <summary>
        /// 真实失效时间
        /// </summary>
        [XmlElement("real_invalid_time")]
        public string RealInvalidTime { get; set; }

        /// <summary>
        /// 真实生效时间
        /// </summary>
        [XmlElement("real_valid_time")]
        public string RealValidTime { get; set; }

        /// <summary>
        /// 目标id
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 商家
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
