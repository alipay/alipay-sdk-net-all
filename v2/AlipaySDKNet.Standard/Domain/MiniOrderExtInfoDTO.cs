using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniOrderExtInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MiniOrderExtInfoDTO : AopObject
    {
        /// <summary>
        /// 预约上门取件的时间点,时间格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("door_time")]
        public string DoorTime { get; set; }

        /// <summary>
        /// 完整的支付参数拼接成的字符串，从服务端获取
        /// </summary>
        [XmlElement("order_str")]
        public string OrderStr { get; set; }
    }
}
