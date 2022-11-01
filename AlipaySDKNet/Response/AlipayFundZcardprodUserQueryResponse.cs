using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundZcardprodUserQueryResponse.
    /// </summary>
    public class AlipayFundZcardprodUserQueryResponse : AopResponse
    {
        /// <summary>
        /// 资产id
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 绑定状态
        /// </summary>
        [XmlElement("bind_status")]
        public string BindStatus { get; set; }
    }
}
