using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScalesActivationCodeDeviceRelationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ScalesActivationCodeDeviceRelationInfo : AopObject
    {
        /// <summary>
        /// 蚂蚁激活码
        /// </summary>
        [XmlElement("activation_code")]
        public string ActivationCode { get; set; }

        /// <summary>
        /// 激活码绑定类型（绑定/解绑）
        /// </summary>
        [XmlElement("bind_type")]
        public string BindType { get; set; }

        /// <summary>
        /// 蚂蚁IOT机具设备号
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 服务商设备号，mac地址
        /// </summary>
        [XmlElement("isv_tid")]
        public string IsvTid { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [XmlElement("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 记录操作类型(激活码/设备白名单)
        /// </summary>
        [XmlElement("relation_type")]
        public string RelationType { get; set; }

        /// <summary>
        /// 设备白名单操作类型(创建/删除)
        /// </summary>
        [XmlElement("white_operate_type")]
        public string WhiteOperateType { get; set; }
    }
}
