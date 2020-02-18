using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiSalesKbassetStuffProduceqrcodeBatchqueryResponse.
    /// </summary>
    public class KoubeiSalesKbassetStuffProduceqrcodeBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前是否还有生产指令可以拉取；注意如果该值为false，也只有提示当前没有更多生产指令了，不代表后面没有生产指令，商户自己需要制定策略定时去拉取
        /// </summary>
        [XmlElement("has_next_page")]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// 口碑码列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("access_produce_qrcode")]
        public List<AccessProduceQrcode> List { get; set; }
    }
}
