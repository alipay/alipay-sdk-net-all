using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpBlueseaactivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpBlueseaactivityQueryModel : AopObject
    {
        /// <summary>
        /// 申请单 id。通过 <a href="https://opendocs.alipay.com/apis/01ebig">alipay.open.sp.blueseaactivity.create</a>接口获取
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
