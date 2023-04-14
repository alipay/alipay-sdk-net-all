using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserDtbankcustActivityorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserDtbankcustActivityorderQueryModel : AopObject
    {
        /// <summary>
        /// 数字分行活动id，activity_order_id为空时必填
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动流水唯一id，由系统自动生成的，在调用活动触发接口会返回该id。
        /// </summary>
        [XmlElement("activity_order_id")]
        public string ActivityOrderId { get; set; }

        /// <summary>
        /// 登录ID 支付宝用户ID 。user_id, logon_id，手机号不能同时为空，优先级依次降低 注：若手机号为非注册账号，则会查询失败
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 本字段映射use_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号，activity_order_id为空时必填
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 用户手机号，user_id, logon_id，手机号不能同时为空，优先级依次降低 注：通过该参数入参将关联用户常用支付宝账号，可能存在误差，请优先使用user_id和logon_id
        /// </summary>
        [XmlElement("phone_id")]
        public string PhoneId { get; set; }

        /// <summary>
        /// 支付宝用户ID 。user_id, logon_id，手机号不能同时为空，优先级依次降低 注：UID为用户唯一标识，可通过授权方式获取，具体见产品文档
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
