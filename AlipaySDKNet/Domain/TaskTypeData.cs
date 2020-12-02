using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskTypeData Data Structure.
    /// </summary>
    [Serializable]
    public class TaskTypeData : AopObject
    {
        /// <summary>
        /// 商户数据回传的任务名称，供C端展示。当累计的数据类型为任务类型时，此为必传字段
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
