using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ModifyQuotaDetails Data Structure.
    /// </summary>
    [Serializable]
    public class ModifyQuotaDetails : AopObject
    {
        /// <summary>
        /// 具体额度，单位：元。如金额为空，表示删除已有的额度设置，无已有额度设置则忽略。
        /// </summary>
        [XmlElement("quota_amount")]
        public string QuotaAmount { get; set; }

        /// <summary>
        /// 额度维度 MONTH/DAY/SINGLE 分别代表月、日、单次
        /// </summary>
        [XmlElement("quota_dimension")]
        public string QuotaDimension { get; set; }

        /// <summary>
        /// PAYER/PAYEE 额度管控的角色，收or付款方，目前只支持付款方
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }
    }
}
