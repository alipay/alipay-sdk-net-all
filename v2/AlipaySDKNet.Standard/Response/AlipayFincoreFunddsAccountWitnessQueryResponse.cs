using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreFunddsAccountWitnessQueryResponse.
    /// </summary>
    public class AlipayFincoreFunddsAccountWitnessQueryResponse : AopResponse
    {
        /// <summary>
        /// 分账托管子户账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 账户状态
        /// </summary>
        [XmlElement("account_status")]
        public string AccountStatus { get; set; }

        /// <summary>
        /// 账户类型, 监管户-SUPERVISED_ACC,托管子户-ENTRUST_SUB_ACC
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 可用余额 ;可用金额=总余额-冻结金额-系统预留金额，业务直接使用即可
        /// </summary>
        [XmlElement("available_balance")]
        public string AvailableBalance { get; set; }

        /// <summary>
        /// 总余额，两位小数，1.23表示1.23元，币种单位：CNY元
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 可变ID，长度<32位即可。用来识别同一个user_id账户下面多维度账户。
        /// </summary>
        [XmlElement("external_entity_id")]
        public string ExternalEntityId { get; set; }

        /// <summary>
        /// 冻结余额 ;需要感知冻结金额的情况
        /// </summary>
        [XmlElement("freeze_balance")]
        public string FreezeBalance { get; set; }

        /// <summary>
        /// 创建时间（格式为：yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间（格式为：yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 用户id或二级商户smid，子户维度。2088开头16位数字
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
