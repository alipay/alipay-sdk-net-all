using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApiScheameTwo Data Structure.
    /// </summary>
    [Serializable]
    public class ApiScheameTwo : AopObject
    {
        /// <summary>
        /// 卡名称
        /// </summary>
        [XmlElement("card_name")]
        public string CardName { get; set; }
    }
}
