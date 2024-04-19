using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BailAuthOrderDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BailAuthOrderDTO : AopObject
    {
        /// <summary>
        /// 保证金协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 保证金剩余可用余额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 保证金预授权号
        /// </summary>
        [XmlElement("auth_no")]
        public string AuthNo { get; set; }

        /// <summary>
        /// 保证金状态。NORMAL——正常，MIGRATED——已迁移
        /// </summary>
        [XmlElement("bail_status")]
        public string BailStatus { get; set; }

        /// <summary>
        /// 资金托管模式，网商模式下返回ANTBANK，余额模式下不返回该字段
        /// </summary>
        [XmlElement("fund_entrust_type")]
        public string FundEntrustType { get; set; }

        /// <summary>
        /// 保证金主单创建时间，格式YYYY-MM-DD HH:MM:SS
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 保证金主单最后修改时间，格式YYYY-MM-DD HH:MM:SS
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 平台uid
        /// </summary>
        [XmlElement("partner_open_id")]
        public string PartnerOpenId { get; set; }

        /// <summary>
        /// 平台uid
        /// </summary>
        [XmlElement("partner_user_id")]
        public string PartnerUserId { get; set; }

        /// <summary>
        /// 保证金产品码，固定BAIL_AUTH
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 场景码描述
        /// </summary>
        [XmlElement("scene_desc")]
        public string SceneDesc { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
