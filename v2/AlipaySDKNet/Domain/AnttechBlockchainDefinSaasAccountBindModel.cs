using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinSaasAccountBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinSaasAccountBindModel : AopObject
    {
        /// <summary>
        /// 户名
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 账户分类
        /// </summary>
        [XmlArray("category")]
        [XmlArrayItem("string")]
        public List<string> Category { get; set; }

        /// <summary>
        /// 银行代码
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 开户网点名称
        /// </summary>
        [XmlElement("offical_name")]
        public string OfficalName { get; set; }

        /// <summary>
        /// 联行号
        /// </summary>
        [XmlElement("offical_number")]
        public string OfficalNumber { get; set; }

        /// <summary>
        /// 外部业务平台会员ID
        /// </summary>
        [XmlElement("out_member_id")]
        public ReferenceId OutMemberId { get; set; }

        /// <summary>
        /// 会员所属业务平台在智能科技的会员ID
        /// </summary>
        [XmlElement("platform_member_id")]
        public string PlatformMemberId { get; set; }

        /// <summary>
        /// 账号主体  I个人；E企业
        /// </summary>
        [XmlElement("principal")]
        public string Principal { get; set; }
    }
}
