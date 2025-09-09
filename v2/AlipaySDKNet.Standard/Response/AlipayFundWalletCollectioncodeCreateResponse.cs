using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundWalletCollectioncodeCreateResponse.
    /// </summary>
    public class AlipayFundWalletCollectioncodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 获取的收款二维码跳转地址
        /// </summary>
        [XmlElement("collection_code_url")]
        public string CollectionCodeUrl { get; set; }
    }
}
