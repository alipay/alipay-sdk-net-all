using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TrafficshareCrowdUserSync Data Structure.
    /// </summary>
    [Serializable]
    public class TrafficshareCrowdUserSync : AopObject
    {
        /// <summary>
        /// 用于标识"增加"操作类型时，该数据是否是增量数据。true:增量数据；false:存量数据
        /// </summary>
        [XmlElement("add_increment_flag")]
        public bool AddIncrementFlag { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        [XmlElement("device_number")]
        public string DeviceNumber { get; set; }

        /// <summary>
        /// 同步类型，枚举。目前支持：增加-add；删除-delete。如果是人群用户新增，传入"add"。如果是对已同步新增人群用户做删除，传入"delete"
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 中国大陆有效的11位手机号加密后的密文，必须加密传入。对应的解密方式由商户侧提供给支付宝出行侧，支付宝出行侧进行解密处理。
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
