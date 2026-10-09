using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainCloudfundSubaccountQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainCloudfundSubaccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 云资金账户号，也是账户外标
        /// </summary>
        [XmlElement("account_ext_no")]
        public string AccountExtNo { get; set; }

        /// <summary>
        /// 云资金账户的状态
        /// </summary>
        [XmlElement("account_status")]
        public string AccountStatus { get; set; }

        /// <summary>
        /// 账户余额
        /// </summary>
        [XmlElement("available_balance")]
        public string AvailableBalance { get; set; }

        /// <summary>
        /// 云资金账户的名字， 创建时生成
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// isv的网商会员role
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }
    }
}
