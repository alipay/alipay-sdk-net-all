using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerContractAcceptCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerContractAcceptCreateModel : AopObject
    {
        /// <summary>
        /// 业务主体id，比如淘宝id
        /// </summary>
        [XmlElement("biz_principal_id")]
        public string BizPrincipalId { get; set; }

        /// <summary>
        /// 业务主体类型
        /// </summary>
        [XmlElement("biz_principal_type")]
        public string BizPrincipalType { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
