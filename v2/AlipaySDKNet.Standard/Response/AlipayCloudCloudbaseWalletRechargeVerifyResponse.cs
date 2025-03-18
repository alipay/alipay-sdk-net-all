using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseWalletRechargeVerifyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseWalletRechargeVerifyResponse : AopResponse
    {
        /// <summary>
        /// 欠费冲正后核销操作返回
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
