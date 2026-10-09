using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CustomInfo : AopObject
    {
        /// <summary>
        /// 金额类描述内容，单位为分 如，title为餐补，amount 为500， 即展示内容为 餐补  ￥5.00
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 非金额类描述内容，长度限制为8. 如，title 为餐补 description 为学生补贴 展示内容即为 餐补    学生补贴
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 用于支付结果页展示，改字段为左侧标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
