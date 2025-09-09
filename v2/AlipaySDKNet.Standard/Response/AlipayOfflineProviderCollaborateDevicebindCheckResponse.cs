using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderCollaborateDevicebindCheckResponse.
    /// </summary>
    public class AlipayOfflineProviderCollaborateDevicebindCheckResponse : AopResponse
    {
        /// <summary>
        /// 设备备注信息，可将该提示展示给小二，由小二决定是否展示二维码给商户签约
        /// </summary>
        [XmlElement("device_remark")]
        public string DeviceRemark { get; set; }

        /// <summary>
        /// true-在白名单中，false-不在白名单中，如果在白名单中设备是直接绑定的，不在白名单中设备需要绑定卖进方案
        /// </summary>
        [XmlElement("in_white_list")]
        public bool InWhiteList { get; set; }

        /// <summary>
        /// true:法人能够签约，false：法人不能签约
        /// </summary>
        [XmlElement("legal_person_is_allow_sign")]
        public bool LegalPersonIsAllowSign { get; set; }
    }
}
