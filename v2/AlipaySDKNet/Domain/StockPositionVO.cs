using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StockPositionVO Data Structure.
    /// </summary>
    [Serializable]
    public class StockPositionVO : AopObject
    {
        /// <summary>
        /// 若返回结果为true表示用户准入该展位，可以展示对应的内容，反之不可以展示对应内容。
        /// </summary>
        [XmlElement("is_show")]
        public bool IsShow { get; set; }

        /// <summary>
        /// 小程序展位ID，由蚂蚁端指定建立分配
        /// </summary>
        [XmlElement("position_code")]
        public string PositionCode { get; set; }
    }
}
