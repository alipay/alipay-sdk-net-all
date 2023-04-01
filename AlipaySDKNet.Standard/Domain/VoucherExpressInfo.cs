using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherExpressInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherExpressInfo : AopObject
    {
        /// <summary>
        /// 邮费标识，属于券的服务，用于用户门槛信息展示
        /// </summary>
        [XmlElement("pay_express")]
        public string PayExpress { get; set; }
    }
}
