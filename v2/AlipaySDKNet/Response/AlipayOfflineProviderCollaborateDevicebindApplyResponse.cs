using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderCollaborateDevicebindApplyResponse.
    /// </summary>
    public class AlipayOfflineProviderCollaborateDevicebindApplyResponse : AopResponse
    {
        /// <summary>
        /// 商户签约链接，需要将该链接生成二维码让商户扫码签约，非白名单情况一定有
        /// </summary>
        [XmlElement("activity_info_url")]
        public string ActivityInfoUrl { get; set; }

        /// <summary>
        /// 设备绑定的状态，有卖进方案的申请，需要在用户签约后接收消息才能拿到状态
        /// </summary>
        [XmlElement("device_bind_status")]
        public string DeviceBindStatus { get; set; }

        /// <summary>
        /// 设备备注信息，可将该提示展示给小二，由小二决定是否展示二维码给商户签约
        /// </summary>
        [XmlElement("device_remark")]
        public string DeviceRemark { get; set; }

        /// <summary>
        /// 设备SN
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// true-在白名单中，false-不在白名单中，如果在白名单中设备是直接绑定的，不在白名单中设备需要绑定卖进方案
        /// </summary>
        [XmlElement("in_white_list")]
        public bool InWhiteList { get; set; }

        /// <summary>
        /// 外部唯一单据号，和申请时传入的一致
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 卖进订单id，有参与卖进订单的一定有
        /// </summary>
        [XmlElement("sales_entry_order_id")]
        public string SalesEntryOrderId { get; set; }

        /// <summary>
        /// 卖进方案id，作业时有卖进方案的必有
        /// </summary>
        [XmlElement("solution_id")]
        public string SolutionId { get; set; }
    }
}
