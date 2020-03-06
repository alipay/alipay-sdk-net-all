using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BccEventDetail Data Structure.
    /// </summary>
    [Serializable]
    public class BccEventDetail : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 事件结果标识:true/false
        /// </summary>
        [XmlElement("complete_tag")]
        public bool CompleteTag { get; set; }

        /// <summary>
        /// 合约单号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 事件内容
        /// </summary>
        [XmlElement("event_conent")]
        public string EventConent { get; set; }

        /// <summary>
        /// 事件发生日期，如打卡日期
        /// </summary>
        [XmlElement("event_day")]
        public string EventDay { get; set; }

        /// <summary>
        /// 事件类型:用来记录事件类型，如钉钉打卡
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 记录系统创建时间
        /// </summary>
        [XmlElement("gm_create")]
        public string GmCreate { get; set; }

        /// <summary>
        /// 应约主体id
        /// </summary>
        [XmlElement("sign_principal_id")]
        public string SignPrincipalId { get; set; }

        /// <summary>
        /// 芝麻roleId
        /// </summary>
        [XmlElement("zm_role_id")]
        public string ZmRoleId { get; set; }
    }
}
