using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantContractBehaviorSyncResponse.
    /// </summary>
    public class ZhimaMerchantContractBehaviorSyncResponse : AopResponse
    {
        /// <summary>
        /// 商户业务订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
