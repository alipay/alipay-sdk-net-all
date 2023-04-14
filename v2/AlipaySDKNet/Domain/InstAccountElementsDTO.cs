using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InstAccountElementsDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InstAccountElementsDTO : AopObject
    {
        /// <summary>
        /// 请款相关要素
        /// </summary>
        [XmlElement("advance_elements")]
        public AdvanceElementsDTO AdvanceElements { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 子卡户名
        /// </summary>
        [XmlElement("sub_account_name")]
        public string SubAccountName { get; set; }

        /// <summary>
        /// 子户类型
        /// </summary>
        [XmlElement("sub_account_type")]
        public string SubAccountType { get; set; }
    }
}
