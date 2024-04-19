using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundFlexiblestaffingEmployeehomeUnsignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundFlexiblestaffingEmployeehomeUnsignModel : AopObject
    {
        /// <summary>
        /// 业务场景码、固定值：EMPLOYEE_HOME_MANAGE
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 要解约的uid， 服务归属方的uid
        /// </summary>
        [XmlElement("principal_open_id")]
        public string PrincipalOpenId { get; set; }

        /// <summary>
        /// 要解约的uid， 服务归属方的uid
        /// </summary>
        [XmlElement("principal_user_id")]
        public string PrincipalUserId { get; set; }

        /// <summary>
        /// 业务产品码，固定值：FLEXIBLE_EMPLOYMENT_SERVICE
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 要解约的服务id， 依赖解约的服务类型，如果类型是RENT_SERVICE，则传服务id，类型是RENT_CONTRACT，则传协议id
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 解约的服务类型 RENT_SERVICE：租赁服务（服务和服务下所有生效协议都会被解除） RENT_CONTRACT：租赁协议（仅协议被解除）
        /// </summary>
        [XmlElement("terminate_type")]
        public string TerminateType { get; set; }
    }
}
