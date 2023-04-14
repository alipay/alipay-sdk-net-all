using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceDataScenicSyncResponse.
    /// </summary>
    public class AlipayCommerceDataScenicSyncResponse : AopResponse
    {
        /// <summary>
        /// 当前景区进见状态的说明
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 对应服务商请求中的outer_id
        /// </summary>
        [XmlElement("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 对应服务商请求中的scenic_app_id
        /// </summary>
        [XmlElement("scenic_app_id")]
        public string ScenicAppId { get; set; }

        /// <summary>
        /// 对应服务商请求中的scenic_id
        /// </summary>
        [XmlElement("scenic_id")]
        public string ScenicId { get; set; }

        /// <summary>
        /// 当前景区的进见状态。可选择值：[AUDITING:审核中， SUCCESS：成功]
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 出现异常 "同一个appId+outerId下不能对应两个景区" 时，才会有值，表示outer_id+scenic_app_id在支付宝域维护的景区ID
        /// </summary>
        [XmlElement("zfb_scenic_id")]
        public string ZfbScenicId { get; set; }
    }
}
