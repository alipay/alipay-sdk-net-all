using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryCustomerByCsdWorkNoReq Data Structure.
    /// </summary>
    [Serializable]
    public class QueryCustomerByCsdWorkNoReq : AopObject
    {
        /// <summary>
        /// csd工号
        /// </summary>
        [XmlElement("csd_work_no")]
        public string CsdWorkNo { get; set; }
    }
}
