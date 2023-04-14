using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAccountExrateConfigQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountExrateConfigQueryModel : AopObject
    {
        /// <summary>
        /// 国际同步到主站的scheduler配置的编码信息,唯一表示一条scheduler配置
        /// </summary>
        [XmlElement("scheduler_code")]
        public string SchedulerCode { get; set; }
    }
}
