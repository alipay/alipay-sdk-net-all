using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundJointaccountRelationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundJointaccountRelationQueryModel : AopObject
    {
        /// <summary>
        /// 账户id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 产品码下的业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 关系绑定的唯一单号，查询绑定关系方式一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 业务场景标识JOINT_ACCOUNT
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 为true代表需要查询基于该关系的支付信息（是否锁定等），不填默认false
        /// </summary>
        [XmlElement("query_payment")]
        public bool QueryPayment { get; set; }

        /// <summary>
        /// 关系绑定id，查询关系方式二
        /// </summary>
        [XmlElement("relation_id")]
        public string RelationId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("request_open_id")]
        public string RequestOpenId { get; set; }

        /// <summary>
        /// （操作人）支付宝侧用户唯一标识
        /// </summary>
        [XmlElement("request_user_id")]
        public string RequestUserId { get; set; }

        /// <summary>
        /// 操作人类型
        /// </summary>
        [XmlElement("request_user_type")]
        public string RequestUserType { get; set; }
    }
}
