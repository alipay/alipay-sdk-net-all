using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandIsvDeviceCreateResponse.
    /// </summary>
    public class AntMerchantExpandIsvDeviceCreateResponse : AopResponse
    {
        /// <summary>
        /// 机具申请物料订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
