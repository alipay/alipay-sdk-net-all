using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayDeviceNlinkNfccallbackSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayDeviceNlinkNfccallbackSyncModel : AopObject
    {
        /// <summary>
        /// 业务code
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务方用户userId
        /// </summary>
        [XmlElement("biz_user_id")]
        public string BizUserId { get; set; }

        /// <summary>
        /// 碰一下回传的业务数据
        /// </summary>
        [XmlElement("nfc_callback_content")]
        public string NfcCallbackContent { get; set; }

        /// <summary>
        /// 动态码token
        /// </summary>
        [XmlElement("ntoken")]
        public string Ntoken { get; set; }

        /// <summary>
        /// 子业务code
        /// </summary>
        [XmlElement("sub_biz_code")]
        public string SubBizCode { get; set; }
    }
}
