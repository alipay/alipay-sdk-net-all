using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReceiptIdentityGroupInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ReceiptIdentityGroupInfo : AopObject
    {
        /// <summary>
        /// 收单身份组id，通过创建收单身份组接口返回获取
        /// </summary>
        [XmlElement("identity_group_id")]
        public string IdentityGroupId { get; set; }

        /// <summary>
        /// 收单身份组名称
        /// </summary>
        [XmlElement("identity_group_name")]
        public string IdentityGroupName { get; set; }
    }
}
