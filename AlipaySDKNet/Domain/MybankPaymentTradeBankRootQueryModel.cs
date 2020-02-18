using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankPaymentTradeBankRootQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeBankRootQueryModel : AopObject
    {
        /// <summary>
        /// 支持全称，或部分名称  如果不传名称，系统默认将返回热门银行，如果用户期望的银行不是热门银行，可以建议用户输入银行名称进行查询。
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }
    }
}
