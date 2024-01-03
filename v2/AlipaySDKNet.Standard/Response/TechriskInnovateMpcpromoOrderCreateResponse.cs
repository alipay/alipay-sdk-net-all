using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// TechriskInnovateMpcpromoOrderCreateResponse.
    /// </summary>
    public class TechriskInnovateMpcpromoOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 小程序云订单
        /// </summary>
        [XmlElement("mpc_order")]
        public MpcOrderVO MpcOrder { get; set; }
    }
}
