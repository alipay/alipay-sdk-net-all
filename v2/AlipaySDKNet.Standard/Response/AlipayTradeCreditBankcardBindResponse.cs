using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeCreditBankcardBindResponse.
    /// </summary>
    public class AlipayTradeCreditBankcardBindResponse : AopResponse
    {
        /// <summary>
        /// 商户可根据该回跳地址进行拉端唤起支付宝并跳转到选卡页面
        /// </summary>
        [XmlElement("schema")]
        public string Schema { get; set; }
    }
}
