using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WitnessPrincipalDTO Data Structure.
    /// </summary>
    [Serializable]
    public class WitnessPrincipalDTO : AopObject
    {
        /// <summary>
        /// 主体账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 主体id(uid,smid等)
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 主体类型 SUPERVISED_ACC:资金监管账户, ENTRUST_SUB_ACC:托管子户, SIGN_ALIPAY_ACC:签约支付宝自有余额账户
        /// </summary>
        [XmlElement("principal_type")]
        public string PrincipalType { get; set; }
    }
}
