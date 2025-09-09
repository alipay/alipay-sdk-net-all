using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SupplierQueryOpenResult Data Structure.
    /// </summary>
    [Serializable]
    public class SupplierQueryOpenResult : AopObject
    {
        /// <summary>
        /// 支付宝账号类型
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 供应商支付宝账号
        /// </summary>
        [XmlElement("supplier_account_no")]
        public string SupplierAccountNo { get; set; }

        /// <summary>
        /// 供应商姓名
        /// </summary>
        [XmlElement("supplier_name")]
        public string SupplierName { get; set; }

        /// <summary>
        /// 供应商联系电话
        /// </summary>
        [XmlElement("supplier_phone")]
        public string SupplierPhone { get; set; }
    }
}
