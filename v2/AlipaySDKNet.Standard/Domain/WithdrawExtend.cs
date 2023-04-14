using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WithdrawExtend Data Structure.
    /// </summary>
    [Serializable]
    public class WithdrawExtend : AopObject
    {
        /// <summary>
        /// 专项金额
        /// </summary>
        [XmlElement("category_condition")]
        public string CategoryCondition { get; set; }
    }
}
