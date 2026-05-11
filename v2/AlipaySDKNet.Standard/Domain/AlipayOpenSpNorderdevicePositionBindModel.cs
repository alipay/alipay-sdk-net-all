using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNorderdevicePositionBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNorderdevicePositionBindModel : AopObject
    {
        /// <summary>
        /// 设备SN号
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 除物料编号外其他支持绑定的物料绑定参数，现支持碰一下链接绑定，都存在时已物料编号为绑定条件
        /// </summary>
        [XmlElement("ext_param")]
        public NOrderTagBindResp ExtParam { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 安装人员ID
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 安装人员姓名
        /// </summary>
        [XmlElement("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 安装人员手机号，用于身份核实
        /// </summary>
        [XmlElement("operator_phone")]
        public string OperatorPhone { get; set; }

        /// <summary>
        /// 安装时间，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("operator_time")]
        public string OperatorTime { get; set; }

        /// <summary>
        /// 创建的点位ID
        /// </summary>
        [XmlElement("position_id")]
        public string PositionId { get; set; }

        /// <summary>
        /// 安装人员ID
        /// </summary>
        [XmlElement("user_open_id")]
        public string UserOpenId { get; set; }
    }
}
