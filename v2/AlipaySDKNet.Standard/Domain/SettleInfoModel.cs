using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SettleInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class SettleInfoModel : AopObject
    {
        /// <summary>
        /// 结算账号,一般是手机号或者邮箱
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 具体办理开户业务的银行分支机构名称
        /// </summary>
        [XmlElement("account_branch_name")]
        public string AccountBranchName { get; set; }

        /// <summary>
        /// 开户支行所在的城市名称（地级市或直辖市）
        /// </summary>
        [XmlElement("account_inst_city")]
        public string AccountInstCity { get; set; }

        /// <summary>
        /// 支行的银行联行号（也称“支付系统行号”）
        /// </summary>
        [XmlElement("account_inst_id")]
        public string AccountInstId { get; set; }

        /// <summary>
        /// 中国工商银行
        /// </summary>
        [XmlElement("account_inst_name")]
        public string AccountInstName { get; set; }

        /// <summary>
        /// 开户支行所在的省级行政区名称
        /// </summary>
        [XmlElement("account_inst_province")]
        public string AccountInstProvince { get; set; }

        /// <summary>
        /// 客户开设银行账户的具体营业网点，通常包括银行名称和支行名称
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 银行卡号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 结算类型设置,0默认是结算到户,目前只支持结算到户
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 账号使用类型：01对公、02对私
        /// </summary>
        [XmlElement("usage_type")]
        public string UsageType { get; set; }
    }
}
