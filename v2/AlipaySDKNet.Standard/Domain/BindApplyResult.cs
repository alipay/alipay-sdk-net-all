using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BindApplyResult Data Structure.
    /// </summary>
    [Serializable]
    public class BindApplyResult : AopObject
    {
        /// <summary>
        /// 设备申请绑定的当前状态（白名单不带卖进方案）
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 本单对应的设备绑定状态
        /// </summary>
        [XmlElement("device_bind_status")]
        public string DeviceBindStatus { get; set; }

        /// <summary>
        /// 设备绑定完成时间
        /// </summary>
        [XmlElement("device_bind_time")]
        public string DeviceBindTime { get; set; }

        /// <summary>
        /// 作业失败的时候告知具体失败情况
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 外部唯一单据号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 如果设备有参与卖进方案，则有
        /// </summary>
        [XmlElement("sales_participate")]
        public DeviceSalesParticipate SalesParticipate { get; set; }
    }
}
