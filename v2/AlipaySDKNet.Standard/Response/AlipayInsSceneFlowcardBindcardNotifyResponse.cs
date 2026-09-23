using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneFlowcardBindcardNotifyResponse.
    /// </summary>
    public class AlipayInsSceneFlowcardBindcardNotifyResponse : AopResponse
    {
        /// <summary>
        /// 申请单号
        /// </summary>
        [XmlElement("ant_ser_apply_no")]
        public string AntSerApplyNo { get; set; }
    }
}
