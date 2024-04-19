using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlarmCompareRule Data Structure.
    /// </summary>
    [Serializable]
    public class AlarmCompareRule : AopObject
    {
        /// <summary>
        /// 比较操作类型  - EQ  - NEQ  - GT  - LT  - LTE  - GTE
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 比较操作的值
        /// </summary>
        [XmlElement("operate_value")]
        public string OperateValue { get; set; }
    }
}
