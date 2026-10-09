using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccountInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class AccountInfoVO : AopObject
    {
        /// <summary>
        /// 账户别名，当前主要用于支付宝，为用户注册邮箱或手机号
        /// </summary>
        [XmlElement("account_alias_name")]
        public string AccountAliasName { get; set; }

        /// <summary>
        /// 账户名称
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 账户性质
        /// </summary>
        [XmlElement("account_nature")]
        public string AccountNature { get; set; }

        /// <summary>
        /// 账户号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 账户类型
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 账户uid
        /// </summary>
        [XmlElement("account_user_id")]
        public string AccountUserId { get; set; }

        /// <summary>
        /// 账户机构ID
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 账户机构名称
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 账户外部机构简称
        /// </summary>
        [XmlElement("out_inst_abbr")]
        public string OutInstAbbr { get; set; }

        /// <summary>
        /// 账户外部机构名称
        /// </summary>
        [XmlElement("out_inst_name")]
        public string OutInstName { get; set; }

        /// <summary>
        /// 账户父机构ID
        /// </summary>
        [XmlElement("parent_inst_id")]
        public string ParentInstId { get; set; }

        /// <summary>
        /// 子账户号 目前(20200211开始)只有招行才可能会有此字段
        /// </summary>
        [XmlElement("sub_account_no")]
        public string SubAccountNo { get; set; }

        /// <summary>
        /// 子账号类型。目前用于区分流水的子账号是 企业识别码 还是 实存子账
        /// </summary>
        [XmlElement("sub_account_type")]
        public string SubAccountType { get; set; }

        /// <summary>
        /// VO基类
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
