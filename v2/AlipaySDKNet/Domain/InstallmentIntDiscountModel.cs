using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InstallmentIntDiscountModel Data Structure.
    /// </summary>
    [Serializable]
    public class InstallmentIntDiscountModel : AopObject
    {
        /// <summary>
        /// 是否有折扣，不包括全部免息
        /// </summary>
        [XmlElement("has_int_discount")]
        public bool HasIntDiscount { get; set; }

        /// <summary>
        /// 是否有免息，仅表示全部免息，不包括部分折扣
        /// </summary>
        [XmlElement("has_int_free")]
        public bool HasIntFree { get; set; }

        /// <summary>
        /// 分期期数
        /// </summary>
        [XmlElement("install_num")]
        public string InstallNum { get; set; }
    }
}
