using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MpcOrderVO Data Structure.
    /// </summary>
    [Serializable]
    public class MpcOrderVO : AopObject
    {
        /// <summary>
        /// 小程序云订单编码
        /// </summary>
        [XmlElement("mpc_order_code")]
        public string MpcOrderCode { get; set; }

        /// <summary>
        /// 小程序云订单链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
