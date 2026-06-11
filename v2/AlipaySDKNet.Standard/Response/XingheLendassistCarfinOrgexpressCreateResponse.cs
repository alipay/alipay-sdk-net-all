using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// XingheLendassistCarfinOrgexpressCreateResponse.
    /// </summary>
    public class XingheLendassistCarfinOrgexpressCreateResponse : AopResponse
    {
        /// <summary>
        /// 星河侧快递单号
        /// </summary>
        [XmlElement("express_no")]
        public string ExpressNo { get; set; }

        /// <summary>
        /// 取件码
        /// </summary>
        [XmlElement("pickup_code")]
        public string PickupCode { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        [XmlElement("refuse_msg")]
        public string RefuseMsg { get; set; }

        /// <summary>
        /// 1：创建成功 2：创建失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        [XmlElement("tracking_no")]
        public string TrackingNo { get; set; }
    }
}
