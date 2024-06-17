using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSupplychainCloudfundSubaccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainCloudfundSubaccountQueryModel : AopObject
    {
        /// <summary>
        /// 云资金账户号
        /// </summary>
        [XmlElement("account_ext_no")]
        public string AccountExtNo { get; set; }

        /// <summary>
        /// ISV信息
        /// </summary>
        [XmlElement("buyer")]
        public Member Buyer { get; set; }

        /// <summary>
        /// 接口扩展信息
        /// </summary>
        [XmlElement("ext_data")]
        public string ExtData { get; set; }

        /// <summary>
        /// 开户分配的机构标记
        /// </summary>
        [XmlElement("isv_org_id")]
        public string IsvOrgId { get; set; }
    }
}
