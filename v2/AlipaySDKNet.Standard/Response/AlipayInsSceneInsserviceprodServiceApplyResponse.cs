using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodServiceApplyResponse.
    /// </summary>
    public class AlipayInsSceneInsserviceprodServiceApplyResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁服务申请单号，机构通知蚂蚁生成服务订单后，返回给机构蚂蚁生成的单号，后续进度交互都需基于此单号
        /// </summary>
        [XmlElement("ant_apply_order_no")]
        public string AntApplyOrderNo { get; set; }
    }
}
