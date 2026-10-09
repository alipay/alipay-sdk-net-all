using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNdeviceWorkBindResponse.
    /// </summary>
    public class AlipayOpenSpNdeviceWorkBindResponse : AopResponse
    {
        /// <summary>
        /// 设备作业绑定结果,false失败可重试
        /// </summary>
        [XmlElement("bind_result")]
        public bool BindResult { get; set; }

        /// <summary>
        /// 碰一下设备SN标识
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 设备类型，主要描述当前碰一下设备类型，如N6
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 外部业务主键ID，用来保证绑定操作重试操作下幂等
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }
    }
}
