using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Dowsure Data Structure.
    /// </summary>
    [Serializable]
    public class Dowsure : AopObject
    {
        /// <summary>
        /// 豆沙包卖家申请单编号
        /// </summary>
        [XmlElement("application_code")]
        public string ApplicationCode { get; set; }
    }
}
