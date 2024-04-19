using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcoContractParticipantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EcoContractParticipantInfo : AopObject
    {
        /// <summary>
        /// 如果该参与人删除了合同，则为1，如果未删除该合同，为0
        /// </summary>
        [XmlElement("delete_status")]
        public string DeleteStatus { get; set; }

        /// <summary>
        /// 参与人名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部商户用户身份标识
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 用户角色，签署合约双方分别为出借人和借款人，同时有一人为合约发起人
        /// </summary>
        [XmlArray("role")]
        [XmlArrayItem("string")]
        public List<string> Role { get; set; }

        /// <summary>
        /// 签署人状态枚举字段
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
