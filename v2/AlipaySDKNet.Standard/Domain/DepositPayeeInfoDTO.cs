using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DepositPayeeInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DepositPayeeInfoDTO : AopObject
    {
        /// <summary>
        /// 描述参与方信息的扩展属性，使用前请与支付宝工程师确认
        /// </summary>
        [XmlElement("ext_info")]
        public RepaymentParticipantExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 参与方的唯一标识。
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 参与方的标识类型，目前支持如下类型：  1、ACCOUNT_BOOK_ID 支付宝的记账本ID  2、EMPLOYEE_ACCOUNT_ID：支付宝的专用金ID
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }
    }
}
