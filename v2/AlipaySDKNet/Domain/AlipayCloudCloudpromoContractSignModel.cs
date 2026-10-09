using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoContractSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoContractSignModel : AopObject
    {
        /// <summary>
        /// 业务机器id，用于埋点数据上报
        /// </summary>
        [XmlElement("apdid_token")]
        public string ApdidToken { get; set; }

        /// <summary>
        /// 租房合同id
        /// </summary>
        [XmlElement("contract_id")]
        public string ContractId { get; set; }

        /// <summary>
        /// 用户主体id
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 用户登录id
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 租房业务的用户角色
        /// </summary>
        [XmlElement("role_type")]
        public string RoleType { get; set; }

        /// <summary>
        /// 用户的签名图片地址
        /// </summary>
        [XmlElement("sign_pic")]
        public string SignPic { get; set; }

        /// <summary>
        /// 三方小程序的appId
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }
    }
}
