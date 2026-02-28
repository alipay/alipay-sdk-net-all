using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ObjectTaskStatus Data Structure.
    /// </summary>
    [Serializable]
    public class ObjectTaskStatus : AopObject
    {
        /// <summary>
        /// 对象放入的篮子编号
        /// </summary>
        [XmlElement("basket_no")]
        public string BasketNo { get; set; }

        /// <summary>
        /// 业务对象编号，如 69?
        /// </summary>
        [XmlElement("biz_object_no")]
        public string BizObjectNo { get; set; }

        /// <summary>
        ///  业务对象序号，从 1 开始
        /// </summary>
        [XmlElement("number")]
        public string Number { get; set; }

        /// <summary>
        /// 业务对象状态，具体参考枚举值
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
