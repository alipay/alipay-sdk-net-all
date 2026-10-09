using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AdvanceElementsDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AdvanceElementsDTO : AopObject
    {
        /// <summary>
        /// 请款绑定支付宝内部账号
        /// </summary>
        [XmlElement("advance_account_no")]
        public string AdvanceAccountNo { get; set; }

        /// <summary>
        /// 请款绑定支付宝账户类型,支持：ENTRUST_SUB_ACC托管子户，SUPERVISED_ACC资金监管账户。auto_advance=true时必填
        /// </summary>
        [XmlElement("advance_account_type")]
        public string AdvanceAccountType { get; set; }

        /// <summary>
        /// 请款绑定支付宝主体id。auto_advance=true时必填
        /// </summary>
        [XmlElement("advance_user_id")]
        public string AdvanceUserId { get; set; }

        /// <summary>
        /// 是否需要自动请款
        /// </summary>
        [XmlElement("auto_advance")]
        public string AutoAdvance { get; set; }
    }
}
