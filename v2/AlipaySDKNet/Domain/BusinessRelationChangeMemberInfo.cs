using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessRelationChangeMemberInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessRelationChangeMemberInfo : AopObject
    {
        /// <summary>
        /// 异动码，TRD_ADD_TOOL-标识机具新增，TRADE_DROP_ZERO-标识机具跌零
        /// </summary>
        [XmlElement("change_code")]
        public string ChangeCode { get; set; }

        /// <summary>
        /// 商业关系门店收单描述
        /// </summary>
        [XmlElement("ip_role_desc")]
        public string IpRoleDesc { get; set; }

        /// <summary>
        /// 商业关系门店收单编号，脱敏的pid信息
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 商业关系门店收单类型，PID/SMID
        /// </summary>
        [XmlElement("ip_role_type")]
        public string IpRoleType { get; set; }
    }
}
